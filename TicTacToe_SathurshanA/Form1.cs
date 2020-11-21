using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_SathurshanA
{
    public partial class Form_TicTacToe : Form
    {
        public Form_TicTacToe()
        {
            InitializeComponent();
        }

        //Global Variables
        //Variables that will determine if a box is already chosen or not
        bool blnBoxOne = false;
        bool blnBoxTwo = false;
        bool blnBoxThree = false;
        bool blnBoxFour = false;
        bool blnBoxFive = false;
        bool blnBoxSix = false;
        bool blnBoxSeven = false;
        bool blnBoxEight = false;
        bool blnBoxNine = false;

        //Variable to determines who's turn it is 
        bool blnPlayerTurn = true;

        //Variables that counts the number of each player moves
        int intPlayerCounter = -1;
        int intComputerCounter = -1;

        //Variables that will keep track of score
        int intComputerScore = 0;
        int intPlayerScore = 0;
        int intNumDraws = 0;

        //Variable that will determine the level difficulty for computer moves
        
        int intComputerDifficulty = 0; // 1 is Easy, 2 is Medium, 3 is Hard

        //Arrays that will keep track of the moves that the players makes (5 is max num of moves)
        int[] intPlayerMovesData = { -99, -99, -99, -99, -99 };
        int[] intComputerMovesData = { -99, -99, -99, -99, -99 };

        Random rndGenerator = new Random();
        private void Form_TicTacToe_Load(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 5, 2020
            //Title: Form_TicTacToe_Load
            //Purpose: Gets the Form ready and disable certain tools so uesr interaction is specifc

            //All buttons are disabled except for EXIT button
            this.btnBoxOne.Enabled = false;
            this.btnBoxTwo.Enabled = false;
            this.btnBoxThree.Enabled = false;
            this.btnBoxFour.Enabled = false;
            this.btnBoxFive.Enabled = false;
            this.btnBoxSix.Enabled = false;
            this.btnBoxSeven.Enabled = false;
            this.btnBoxEight.Enabled = false;
            this.btnBoxNine.Enabled = false;
            this.btnRestart.Enabled = false;
            this.btnStart.Enabled = false;

            //Radiobuttons are all ceckhed false, but enabled true
            this.rdoEasy.Checked = false;
            this.rdoMedium.Checked = false;
            this.rdoHARD.Checked = false;

            //Display the score: All will display 0
            this.lblComputerScore.Text = intComputerScore.ToString();
            this.lblPlayerScore.Text = intPlayerScore.ToString();
            this.lblNumDrawsDisplay.Text = intNumDraws.ToString();

            //Directions for user
            this.lblMessage.Text = "Please choose a level difficulty. Then Press Start.";
        }
        public void StartGame()
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 3, 2020
            //Title: StartGame
            //Purpose: Enable tools for user to interact inorder to play the actual game

            //Enable all gameboard buttons
            this.btnBoxOne.Enabled = true;
            this.btnBoxTwo.Enabled = true;
            this.btnBoxThree.Enabled = true;
            this.btnBoxFour.Enabled = true;
            this.btnBoxFive.Enabled = true;
            this.btnBoxSix.Enabled = true;
            this.btnBoxSeven.Enabled = true;
            this.btnBoxEight.Enabled = true;
            this.btnBoxNine.Enabled = true;

            //Enable RESTART button and disable START button
            this.btnRestart.Enabled = true;
            this.btnStart.Enabled = false;

            //Disable all radiobuttons
            this.rdoEasy.Enabled = false;
            this.rdoMedium.Enabled = false;
            this.rdoHARD.Enabled = false;

            //Gives directions for user for more options
            this.lblMessage.Text = "Press RESTART at any time to choose a new diffculty level \nPress EXIT at any time to leave the application.";

            //Tells user that they have the first move
            MessageBox.Show("You go first");
        }
        public void ComputerTurn()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 4, 2020
            //Title: ComputerTurn
            //Purpose: To run specific methods for the level difficulty that the user chose at the beginning

            //1 is Easy, 2 is Medium, 3 is Hard
            if (intComputerDifficulty == 1)
            {
                ComputerTurnEasy();
            }
            else if (intComputerDifficulty == 2)
            {
                ComputerTurnMedium();
            }
            else if (intComputerDifficulty == 3)
            {
                ComputerTurnHard();
            }
        }
        public void ComputerTurnHard()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 6, 2020
            //Title: ComputerTurnHard
            //Purpose: Determine the Computer Moves when the difficulty level is Hard

            //Variables
            int intRandomComputerBoxSmart;
            int intComputerMove;
            int intLoopCounter = 0;
            int intComputerDefence;
            int intComputerAttack;

            //Process
            intComputerDefence = DefenceHard(intPlayerMovesData, intPlayerCounter);
            intComputerAttack = DefenceHard(intComputerMovesData, intComputerCounter);
            intComputerMove = intComputerAttack;

            intComputerCounter++;

            //Loop twice, First time will loop to see if function return gives a value to attack, if not, then will run again to see if return value tells to defend
            while (intLoopCounter < 2)
            {
                //Box 1
                if (intComputerMove == 1)
                {
                    this.btnBoxOne.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 2;
                    blnBoxOne = true;
                    this.btnBoxOne.Enabled = false;
                    break;
                }
                //Box 2
                else if (intComputerMove == 2)
                {
                    this.btnBoxTwo.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 9;
                    blnBoxTwo = true;
                    this.btnBoxTwo.Enabled = false;
                    break;
                }
                //Box 3
                else if (intComputerMove == 3)
                {
                    this.btnBoxThree.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 4;
                    blnBoxThree = true;
                    this.btnBoxThree.Enabled = false;
                    break;
                }
                //Box 4
                else if (intComputerMove == 4)
                {
                    this.btnBoxFour.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 7;
                    blnBoxFour = true;
                    this.btnBoxFour.Enabled = false;
                    break;
                }
                //Box 5
                else if (intComputerMove == 5)
                {
                    this.btnBoxFive.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 5;
                    blnBoxFive = true;
                    this.btnBoxFive.Enabled = false;
                    break;
                }
                //Box 6
                else if (intComputerMove == 6)
                {
                    this.btnBoxSix.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 3;
                    blnBoxSix = true;
                    this.btnBoxSix.Enabled = false;
                    break;
                }
                //Box 7
                else if (intComputerMove == 7)
                {
                    this.btnBoxSeven.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 6;
                    blnBoxSeven = true;
                    this.btnBoxSeven.Enabled = false;
                    break;
                }
                //Box 8
                else if (intComputerMove == 8)
                {
                    this.btnBoxEight.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 1;
                    blnBoxEight = true;
                    this.btnBoxEight.Enabled = false;
                    break;
                }
                //Box 9
                else if (intComputerMove == 9)
                {
                    this.btnBoxNine.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 8;
                    blnBoxNine = true;
                    this.btnBoxNine.Enabled = false;
                    break;
                }
                //if return value of attack was 0, loop again to see if the return value of defend will make a move
                else if (intComputerMove == 0)
                {
                    intComputerMove = intComputerDefence;
                }

                intLoopCounter++;
            }

            //If the function return says that there is no possible attack or defend moves, computer will make smart random moves
            if (intComputerDefence == 0 && intComputerAttack == 0)
            {
                while (true)
                {
                    intRandomComputerBoxSmart = rndGenerator.Next(1, 5); //1 is box ONE, 2 is box THREE, 3 is box SEVEN, 4 is box NINE

                    //First Computer will try to take middle box (box 5) if available
                    if (blnBoxFive == false)
                    {
                        this.btnBoxFive.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 5;
                        blnBoxFive = true;
                        this.btnBoxFive.Enabled = false;
                        break;
                    }
                    //Then computer will try to take the corner boxes if available
                    else if (intRandomComputerBoxSmart == 1 && blnBoxOne == false) //Box 1
                    {
                        this.btnBoxOne.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 2;
                        blnBoxOne = true;
                        this.btnBoxOne.Enabled = false;
                        break;
                    }
                    else if (intRandomComputerBoxSmart == 2 && blnBoxThree == false) //Box 3
                    {
                        this.btnBoxThree.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 4;
                        blnBoxThree = true;
                        this.btnBoxThree.Enabled = false;
                        break;
                    }
                    else if (intRandomComputerBoxSmart == 3 && blnBoxSeven == false) //Box 7
                    {
                        this.btnBoxSeven.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 6;
                        blnBoxSeven = true;
                        this.btnBoxSeven.Enabled = false;
                        break;
                    }
                    else if (intRandomComputerBoxSmart == 4 && blnBoxNine == false) //Box 9
                    {
                        this.btnBoxNine.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 8;
                        blnBoxNine = true;
                        this.btnBoxNine.Enabled = false;
                        break;
                    }
                    //If all boxes above are taken computer will try to take the rest of the boxes
                    else if (blnBoxOne == true && blnBoxThree == true && blnBoxSeven == true && blnBoxNine == true)
                    {
                        //From intRandomComputerBoxSmart: 1 is Box TWO, 2 is Box FOUR, 3 is Box SIX, 4 is Box Eight
                        if (intRandomComputerBoxSmart == 1 && blnBoxTwo == false) //Box 2
                        {
                            this.btnBoxTwo.BackgroundImage = Pictures_Sa.RedCross_SA;
                            intComputerMovesData[intComputerCounter] = 9;
                            blnBoxTwo = true;
                            this.btnBoxTwo.Enabled = false;
                            break;
                        }
                        else if (intRandomComputerBoxSmart == 2 && blnBoxFour == false) //Box 4
                        {
                            this.btnBoxFour.BackgroundImage = Pictures_Sa.RedCross_SA;
                            intComputerMovesData[intComputerCounter] = 7;
                            blnBoxFour = true;
                            this.btnBoxFour.Enabled = false;
                            break;
                        }
                        else if (intRandomComputerBoxSmart == 3 && blnBoxSix == false) //Box 6
                        {
                            this.btnBoxSix.BackgroundImage = Pictures_Sa.RedCross_SA;
                            intComputerMovesData[intComputerCounter] = 3;
                            blnBoxSix = true;
                            this.btnBoxSix.Enabled = false;
                            break;
                        }
                        else if (intRandomComputerBoxSmart == 4 && blnBoxEight == false) //Box 8
                        {
                            this.btnBoxEight.BackgroundImage = Pictures_Sa.RedCross_SA;
                            intComputerMovesData[intComputerCounter] = 1;
                            blnBoxEight = true;
                            this.btnBoxEight.Enabled = false;
                            break;
                        }
                    }
                }
            }

            //Player turn next
            blnPlayerTurn = true;
            
            //Check for winner 
            WinnerCheck();
        }
        public int DefenceHard(int[] intBoxNum, int intCounter)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 6, 2020
            //Title: DefenceHard
            //Purpose: To return a computer move value based on a position if computer can attack or defend

            //Variables
            int intNextComputerMove = 0;

            //Process
            //Special Case DEFENCE # 1 
            //If user first two moves are opposite corners, Computer must take box 8 to defend
            if (intPlayerMovesData[0] % 2 == 0 && intPlayerMovesData[0] + intPlayerMovesData[1] == 10 && blnBoxEight == false)
            {
                intNextComputerMove = 8;
            }

            //Special Case DEFENCE #2
            //If User first two moves is a opposite corner and opposite edge, then Computer must take certain moves dpending on location of user moves
            if (intPlayerMovesData[0] == 2 && (intPlayerMovesData[1] == 3 || intPlayerMovesData[1] == 1) && blnBoxNine == false)
            {
                intNextComputerMove = 9;
            }
            else if (intPlayerMovesData[0] == 4 && (intPlayerMovesData[1] == 7 || intPlayerMovesData[1] == 1) && blnBoxSeven == false)
            {
                intNextComputerMove = 7;
            }
            else if (intPlayerMovesData[0] == 6 && (intPlayerMovesData[1] == 9 || intPlayerMovesData[1] == 3) && blnBoxThree == false)
            {
                intNextComputerMove = 3;
            }
            else if (intPlayerMovesData[0] == 8 && (intPlayerMovesData[1] == 9 || intPlayerMovesData[1] == 7) && blnBoxOne == false)
            {
                intNextComputerMove = 1;
            }

            //Special Case DEFENCE #3
            //If User first two moves is aedge and opposite corner, then Computer must take certain moves dpending on location of user moves
            if (intPlayerMovesData[1] == 2 && (intPlayerMovesData[0] == 3 || intPlayerMovesData[0] == 1) && blnBoxNine == false)
            {
                intNextComputerMove = 9;
            }
            else if (intPlayerMovesData[1] == 4 && (intPlayerMovesData[0] == 7 || intPlayerMovesData[0] == 1) && blnBoxSeven == false)
            {
                intNextComputerMove = 7;
            }
            else if (intPlayerMovesData[1] == 6 && (intPlayerMovesData[0] == 9 || intPlayerMovesData[0] == 3) && blnBoxThree == false)
            {
                intNextComputerMove = 3;
            }
            else if (intPlayerMovesData[1] == 8 && (intPlayerMovesData[0] == 9 || intPlayerMovesData[0] == 7) && blnBoxOne == false)
            {
                intNextComputerMove = 1;
            }

            //DEFENCE AND ATTACK
            //This will check every box to see if computer can win to attack or defend
            //This is solved by taking the difference of all players move and matching it with perfect 15 number sequence
            for (int i = intCounter; i > 0; i--)
            {
                if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 2 && blnBoxOne == false)
                {
                    intNextComputerMove = 1;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 9 && blnBoxTwo == false)
                {
                    intNextComputerMove = 2;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 4 && blnBoxThree == false)
                {
                    intNextComputerMove = 3;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 7 && blnBoxFour == false)
                {
                    intNextComputerMove = 4;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 5 && blnBoxFive == false)
                {
                    intNextComputerMove = 5;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 3 && blnBoxSix == false)
                {
                    intNextComputerMove = 6;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 6 && blnBoxSeven == false)
                {
                    intNextComputerMove = 7;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 1 && blnBoxEight == false)
                {
                    intNextComputerMove = 8;
                }
                else if (15 - intBoxNum[intCounter] - intBoxNum[intCounter - i] == 8 && blnBoxNine == false)
                {
                    intNextComputerMove = 9;
                }
            }

            return intNextComputerMove;
        }
        public void ComputerTurnMedium()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 5, 2020
            //Title: ComputerTurnMedium
            //Purpose: Method that will control the computer moves when level difficulty is medium 

            //Variables
            int intRandomComputerBoxSmart;

            //Process
            intComputerCounter++;

            while(true)
            {
                intRandomComputerBoxSmart = rndGenerator.Next(1, 5); //1 is box ONE, 2 is box THREE, 3 is box SEVEN, 4 is box NINE
                
                //First Computer will try to take middle box (box 5) if available
                if (blnBoxFive == false)
                {
                    this.btnBoxFive.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 5;
                    blnBoxFive = true;
                    this.btnBoxFive.Enabled = false;
                    break;
                }
                //Then computer will try to take the corner boxes if available
                else if (intRandomComputerBoxSmart == 1 && blnBoxOne == false) //Box 1
                {
                    this.btnBoxOne.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 2;
                    blnBoxOne = true;
                    this.btnBoxOne.Enabled = false;
                    break;
                }
                else if (intRandomComputerBoxSmart == 2 && blnBoxThree == false)  //Box 3
                {
                    this.btnBoxThree.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 4;
                    blnBoxThree = true;
                    this.btnBoxThree.Enabled = false;
                    break;
                }
                else if (intRandomComputerBoxSmart == 3 && blnBoxSeven == false)  //Box 7
                {
                    this.btnBoxSeven.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 6;
                    blnBoxSeven = true;
                    this.btnBoxSeven.Enabled = false;
                    break;
                }
                else if (intRandomComputerBoxSmart == 4 && blnBoxNine == false)  //Box 9
                {
                    this.btnBoxNine.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 8;
                    blnBoxNine = true;
                    this.btnBoxNine.Enabled = false;
                    break;
                }
                //If all above are already taken then computer will try to take the edge boxes
                else if (blnBoxOne == true && blnBoxThree == true && blnBoxSeven == true && blnBoxNine == true)
                {
                    //From intRandomComputerBoxSmart: 1 is Box TWO, 2 is Box FOUR, 3 is Box SIX, 4 is Box Eight
                    if (intRandomComputerBoxSmart == 1 && blnBoxTwo == false)  //Box 2
                    {
                        this.btnBoxTwo.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 9;
                        blnBoxTwo = true;
                        this.btnBoxTwo.Enabled = false;
                        break;
                    }
                    else if (intRandomComputerBoxSmart == 2 && blnBoxFour == false) //Box 4
                    {
                        this.btnBoxFour.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 7;
                        blnBoxFour = true;
                        this.btnBoxFour.Enabled = false;
                        break;
                    }
                    else if (intRandomComputerBoxSmart == 3 && blnBoxSix == false)  //Box 6
                    {
                        this.btnBoxSix.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 3;
                        blnBoxSix = true;
                        this.btnBoxSix.Enabled = false;
                        break;
                    }
                    else if (intRandomComputerBoxSmart == 4 && blnBoxEight == false)  //Box 8
                    {
                        this.btnBoxEight.BackgroundImage = Pictures_Sa.RedCross_SA;
                        intComputerMovesData[intComputerCounter] = 1;
                        blnBoxEight = true;
                        this.btnBoxEight.Enabled = false;
                        break;
                    }
                }
            }

            //set player turn next
            blnPlayerTurn = true;

            //Check for winner
            WinnerCheck();
        }
        public void ComputerTurnEasy()
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: ComputerTurnEasy
            //Purpose: To determine computer moves, when difficulty level is set to easy

            //Variables 
            int intRandomComputerBox;

            //Process
            intComputerCounter++;

            while (true)
            {
                //Randonly generates a number between 1 and 9 inclusive
                intRandomComputerBox = rndGenerator.Next(1, 10);

                //Set randomnumber as the computermove if that box is not taken

                if (intRandomComputerBox == 1 && blnBoxOne == false)  //Box 1
                {
                    this.btnBoxOne.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 2;
                    blnBoxOne = true;
                    this.btnBoxOne.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 2 && blnBoxTwo == false)  //Box 2
                {
                    this.btnBoxTwo.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 9;
                    blnBoxTwo = true;
                    this.btnBoxTwo.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 3 && blnBoxThree == false) //Box 3
                {
                    this.btnBoxThree.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 4;
                    blnBoxThree = true;
                    this.btnBoxThree.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 4 && blnBoxFour == false) //Box 4
                {
                    this.btnBoxFour.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 7;
                    blnBoxFour = true;
                    this.btnBoxFour.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 5 && blnBoxFive == false) //Box 5
                {
                    this.btnBoxFive.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 5;
                    blnBoxFive = true;
                    this.btnBoxFive.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 6 && blnBoxSix == false) //Box 6
                {
                    this.btnBoxSix.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 3;
                    blnBoxSix = true;
                    this.btnBoxSix.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 7 && blnBoxSeven == false) //Box 7
                {
                    this.btnBoxSeven.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 6;
                    blnBoxSeven = true;
                    this.btnBoxSeven.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 8 && blnBoxEight == false) //Box 8
                {
                    this.btnBoxEight.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 1;
                    blnBoxEight = true;
                    this.btnBoxEight.Enabled = false;
                    break;
                }
                if (intRandomComputerBox == 9 && blnBoxNine == false) //Box 9
                {
                    this.btnBoxNine.BackgroundImage = Pictures_Sa.RedCross_SA;
                    intComputerMovesData[intComputerCounter] = 8;
                    blnBoxNine = true;
                    this.btnBoxNine.Enabled = false;
                    break;
                }
            }
            //Set player trun next
            blnPlayerTurn = true;

            //Check for winner
            WinnerCheck();
        }
        public void WinnerCheck()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 3, 2020
            //Title: WinnerCheck
            //Purpose: Display if there is a winner

            //Output
            //If computer wins
            if (WinnerResult(intComputerMovesData))
            {
                //Add one to computer score
                intComputerScore++;
                this.lblComputerScore.Text = intComputerScore.ToString();
                MessageBox.Show("COMPUTER WINS");
                NewRound();
            }
            //If Player wins
            else if (WinnerResult(intPlayerMovesData))
            {
                //Add one to player score
                intPlayerScore++;
                this.lblPlayerScore.Text = intPlayerScore.ToString();
                MessageBox.Show("YOU WIN!");
                NewRound();
            }
            //If it is a draw
            else if (intComputerCounter == 4 || intPlayerCounter == 4)
            {
                //Add one to number fo draw counter
                intNumDraws++;
                this.lblNumDrawsDisplay.Text = intNumDraws.ToString();
                MessageBox.Show("ITS A DRAW!");
                NewRound();
            }
        }
        public bool WinnerResult (int[] intBoxes)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 3, 2020
            //Title: WinnerResult
            //Purpose: To calculate to see if there is any winner

            //Variables
            bool blnWinner = false;

            //Process
            //Add all 10 possible combinations of total moves to see if eaul to 15
            //According to magic square, if it adds to 15, there is a winner

            if (intBoxes[0] + intBoxes[1] + intBoxes[2] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[0] + intBoxes[1] + intBoxes[3] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[0] + intBoxes[1] + intBoxes[4] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[0] + intBoxes[2] + intBoxes[3] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[0] + intBoxes[2] + intBoxes[4] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[0] + intBoxes[3] + intBoxes[4] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[1] + intBoxes[2] + intBoxes[3] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[1] + intBoxes[2] + intBoxes[4] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[1] + intBoxes[3] + intBoxes[4] == 15)
            {
                blnWinner = true;
            }
            else if (intBoxes[2] + intBoxes[3] + intBoxes[4] == 15)
            {
                blnWinner = true;
            }

            return blnWinner;
        }
        public void NewRound()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 5, 2020
            //Title: NewRound
            //Purpose: To reset the form for a new round

            //Set all blnBox Values to false
            blnBoxOne = false;
            blnBoxTwo = false;
            blnBoxThree = false;
            blnBoxFour = false;
            blnBoxFive = false;
            blnBoxSix = false;
            blnBoxSeven = false;
            blnBoxEight = false;
            blnBoxNine = false;

            //Reset the background image to nothing
            this.btnBoxOne.BackgroundImage = null;
            this.btnBoxTwo.BackgroundImage = null;
            this.btnBoxThree.BackgroundImage = null;
            this.btnBoxFour.BackgroundImage = null;
            this.btnBoxFive.BackgroundImage = null;
            this.btnBoxSix.BackgroundImage = null;
            this.btnBoxSeven.BackgroundImage = null;
            this.btnBoxEight.BackgroundImage = null;
            this.btnBoxNine.BackgroundImage = null;

            //Enable all the game board buttons
            this.btnBoxOne.Enabled = true;
            this.btnBoxTwo.Enabled = true;
            this.btnBoxThree.Enabled = true;
            this.btnBoxFour.Enabled = true;
            this.btnBoxFive.Enabled = true;
            this.btnBoxSix.Enabled = true;
            this.btnBoxSeven.Enabled = true;
            this.btnBoxEight.Enabled = true;
            this.btnBoxNine.Enabled = true;

            //Reset player moves counter
            intPlayerCounter = -1;
            intComputerCounter = -1;

            //Reset the move value data array to -99
            for (int i = 0; i < 5; i++)
            {
                intPlayerMovesData[i] = -99;
                intComputerMovesData[i] = -99;
            }

            //Informs who goes first: The last person to play in last game goes second, and the other person goes first
            if (blnPlayerTurn == false)
            {
                MessageBox.Show("Computer goes first");
            }
            else
            {
                MessageBox.Show("You go first");
            }
        }
        private void btnBoxOne_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxOne_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 1 

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 2;
            intPlayerCounter++;

            if(blnBoxOne == false)
            {
                this.btnBoxOne.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxOne.Enabled = false;
            }

            blnBoxOne = true;

            //Check for winner
            WinnerCheck();

            //Computer's Turn
            ComputerTurn();
        }

        private void btnBoxTwo_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxTwo_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 2 

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 9;
            intPlayerCounter++;

            if (blnBoxTwo == false)
            {
                this.btnBoxTwo.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxTwo.Enabled = false;
            }

            blnBoxTwo = true;
            
            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }

        private void btnBoxThree_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxThree_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 3

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 4;
            intPlayerCounter++;

            if (blnBoxThree == false)
            {
                this.btnBoxThree.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxThree.Enabled = false;
            }

            blnBoxThree = true;

            //check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }

        private void btnBoxFour_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxFour_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 4

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 7;
            intPlayerCounter++;

            if (blnBoxFour == false)
            {
                this.btnBoxFour.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxFour.Enabled = false;
            }

            blnBoxFour = true;

            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }

        private void btnBoxFive_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxFive_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 5

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 5;
            intPlayerCounter++;

            if (blnBoxFive == false)
            {
                this.btnBoxFive.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxFive.Enabled = false;
            }

            blnBoxFive = true;

            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }

        private void btnBoxSix_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxSix_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 6

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 3;
            intPlayerCounter++;

            if (blnBoxSix == false)
            {
                this.btnBoxSix.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxSix.Enabled = false;
            }

            blnBoxSix = true;

            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }
        private void btnBoxSeven_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxSeven_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 7

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 6;
            intPlayerCounter++;

            if (blnBoxSeven == false)
            {
                this.btnBoxSeven.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxSeven.Enabled = false;
            }

            blnBoxSeven = true;

            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }
        private void btnBoxEight_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxEight_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 8 

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 1;
            intPlayerCounter++;

            if (blnBoxEight == false)
            {
                this.btnBoxEight.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxEight.Enabled = false;
            }

            blnBoxEight = true;

            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }
        private void btnBoxNine_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 2, 2020
            //Title: btnBoxNine_Click
            //Purpose: Runs all neccessary procedures when user clicks on box 9

            //Variables
            int intBoxValue;

            //Process and Output
            intBoxValue = 8;
            intPlayerCounter++;

            if (blnBoxNine == false)
            {
                this.btnBoxNine.BackgroundImage = Pictures_Sa.GoldCoin_SA;
                intPlayerMovesData[intPlayerCounter] = intBoxValue;
                blnPlayerTurn = false;
                this.btnBoxNine.Enabled = false;
            }

            blnBoxNine = true;

            //Check for winner
            WinnerCheck();

            //Computer's turn
            ComputerTurn();
        }

        private void rdoEasy_CheckedChanged(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 3, 2020
            //Title: rdoEasy_CheckedChanged
            //Purpose: Enable the game with a selectef difficult as easy

            //Easy
            intComputerDifficulty = 1;

            //Enables START button
            this.btnStart.Enabled = true;
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 3, 2020
            //Title: rdoMedium_CheckedChanged
            //Purpose: Enable the game with a selectef difficult as Medium

            //Medium
            intComputerDifficulty = 2;

            //Enables START button
            this.btnStart.Enabled = true;
        }

        private void rdoHARD_CheckedChanged(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 3, 2020
            //Title: rdoHARD_CheckedChanged
            //Purpose: Enable the game with a selectef difficult as hard

            //Hard
            intComputerDifficulty = 3;

            //Enables START button
            this.btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 3, 2020
            //Title:  btnStart_Click
            //Purpose: Starts the game when the button is clicked

            StartGame();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 3, 2020
            //Title:  btnRestart_Click
            //Purpose: To reset the game so that it is ready for a new difficulty level

            //Enable all radiobuttons
            this.rdoEasy.Enabled = true;
            this.rdoMedium.Enabled = true;
            this.rdoHARD.Enabled = true;

            //Disable the RESTART button
            this.btnRestart.Enabled = false;
            
            //Enable the START button
            this.btnStart.Enabled = true;

            //Set all the blnBox to false
            blnBoxOne = false;
            blnBoxTwo = false;
            blnBoxThree = false;
            blnBoxFour = false;
            blnBoxFive = false;
            blnBoxSix = false;
            blnBoxSeven = false;
            blnBoxEight = false;
            blnBoxNine = false;

            //Reset the background image to all game board buttons 
            this.btnBoxOne.BackgroundImage = null;
            this.btnBoxTwo.BackgroundImage = null;
            this.btnBoxThree.BackgroundImage = null;
            this.btnBoxFour.BackgroundImage = null;
            this.btnBoxFive.BackgroundImage = null;
            this.btnBoxSix.BackgroundImage = null;
            this.btnBoxSeven.BackgroundImage = null;
            this.btnBoxEight.BackgroundImage = null;
            this.btnBoxNine.BackgroundImage = null;

            //Disable all buttons
            this.btnBoxOne.Enabled = false;
            this.btnBoxTwo.Enabled = false;
            this.btnBoxThree.Enabled = false;
            this.btnBoxFour.Enabled = false;
            this.btnBoxFive.Enabled = false;
            this.btnBoxSix.Enabled = false;
            this.btnBoxSeven.Enabled = false;
            this.btnBoxEight.Enabled = false;
            this.btnBoxNine.Enabled = false;

            //Reset player counters
            intPlayerCounter = -1;
            intComputerCounter = -1;

            //Reset the player move data array: set all values to -99
            for (int i = 0; i < 5; i++)
            {
                intPlayerMovesData[i] = -99;
                intComputerMovesData[i] = -99;
            }

            //Reset all scores to 0
            intComputerScore = 0;
            intPlayerScore = 0;
            intNumDraws = 0;

            //Output the scores so user knows scores have been resetted
            this.lblComputerScore.Text = intComputerScore.ToString();
            this.lblPlayerScore.Text = intPlayerScore.ToString();
            this.lblNumDrawsDisplay.Text = intNumDraws.ToString();

            //Gives isntructions on next steps 
            this.lblMessage.Text = "Please choose a level difficulty. Then Press START.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application 
            Application.Exit();
        }

       
    }
}