using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _943passwordgenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        string codeString = "INVALID";
        int selectOffenseInt, selectSpecialWeaponEnergyInt;
        string selectOffenseString, selectSpecialWeaponEnergyString;


        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void PasswordGeneratorForm_Load(object sender, EventArgs e)
        {
            int x;
            x = 1;

            while (x < 24)
            {
                selectLevelComboBox.Items.Add(x);
                x += 1;
            }

            selectLevelComboBox.SelectedIndex = 0;

            x = 1;
            while (x < 7)
            {
                selectDefenseComboBox.Items.Add(x);
                selectOffenseComboBox.Items.Add(x);
                selectPlaneEnergyLevelComboBox.Items.Add(x);
                selectSpecialWeaponStrengthComboBox.Items.Add(x);
                selectSpecialWeaponTimeLimitComboBox.Items.Add(x);
                x += 1;
            }
            selectDefenseComboBox.SelectedIndex = 0;
            selectOffenseComboBox.SelectedIndex = 0;
            selectPlaneEnergyLevelComboBox.SelectedIndex = 0;
            selectSpecialWeaponStrengthComboBox.SelectedIndex = 0;
            selectSpecialWeaponTimeLimitComboBox.SelectedIndex = 0;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateCodeButton_Click(object sender, EventArgs e)
        {
            string digitOneString, digitTwoString, digitThreeString, digitFourString,
                digitFiveString;

            GetDigitOne();
            digitOneString = GetDigitOne();
            GetDigitTwo();
            digitTwoString = GetDigitTwo();
            GetDigitThree();
            digitThreeString = GetDigitThree();
            GetDigitFour();
            digitFourString = GetDigitFour();
            GetDigitFive();
            digitFiveString = GetDigitFive();



            if (digitFiveString != "INVALID")
            {
                codeTextBox.Text = digitOneString + digitTwoString + digitThreeString
                    + digitFourString + digitFiveString;
            }
            else
                codeTextBox.Text = "INVALID";
            }

        private string GetDigitOne()
        {
            int levelSelectInt;
            string levelSelectString;

            levelSelectInt = int.Parse(selectLevelComboBox.Text);
            levelSelectString = levelSelectInt.ToString();

            switch (levelSelectString)
            {
                case "1":
                    codeString = "0";
                    break;
                case "2":
                    codeString = "7";
                    break;
                case "3":
                    codeString = "E";
                    break;
                case "4":
                    codeString = "L";
                    break;
                case "5":
                    codeString = "S";
                    break;
                case "6":
                    codeString = "Z";
                    break;
                case "7":
                    codeString = "I";
                    break;
                case "8":
                    codeString = "P";
                    break;
                case "9":
                    codeString = "W";
                    break;
                case "10":
                    codeString = "3";
                    break;
                case "11":
                    codeString = "A";
                    break;
                case "12":
                    codeString = "H";
                    break;
                case "13":
                    codeString = "U";
                    break;
                case "14":
                    codeString = "5";
                    break;
                case "15":
                    codeString = "K";
                    break;
                case "16":
                    codeString = "F";
                    break;
                case "17":
                    codeString = "1";
                    break;
                case "18":
                    codeString = "6";
                    break;
                case "19":
                    codeString = "8";
                    break;
                case "20":
                    codeString = "D";
                    break;
                case "21":
                    codeString = "M";
                    break;
                case "22":
                    codeString = "R";
                    break;
                case "23":
                    codeString = "T";
                    break;
         
            
            }
            return codeString;
        }

        private string GetDigitTwo()
        {
            int selectDefenseInt;
            string selectDefenseString;

            selectDefenseInt = int.Parse(selectDefenseComboBox.Text);
            selectDefenseString = selectDefenseInt.ToString();

            selectOffenseInt = int.Parse(selectOffenseComboBox.Text);
            selectOffenseString = selectOffenseInt.ToString();


            switch (selectDefenseString)
            {
                case "1":
                    GetDigitTwoCaseOne();
                    codeString = GetDigitTwoCaseOne();
                    break;
                case "2":
                    GetDigitTwoCaseTwo();
                    codeString = GetDigitTwoCaseTwo();
                    break;
                case "3":
                    GetDigitTwoCaseThree();
                    codeString = GetDigitTwoCaseThree();
                    break;
                case "4":
                    GetDigitTwoCaseFour();
                    codeString = GetDigitTwoCaseFour();
                    break;
                case "5":
                    GetDigitTwoCaseFive();
                    codeString = GetDigitTwoCaseFive();
                    break;
                case "6":
                    GetDigitTwoCaseSix();
                    codeString = GetDigitTwoCaseSix();
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseOne()
        {
            switch (selectOffenseString)
            {
                case "1":
                    codeString = "3";
                    break;
                case "2":
                    codeString = "A";
                    break;
                case "3":
                    codeString = "H";
                    break;
                case "4":
                    codeString = "I";
                    break;
                case "5":
                    codeString = "P";
                    break;
                case "6":
                    codeString = "W";
                    break;
            }
            return codeString;
        }


        private string GetDigitTwoCaseTwo()
        {
            switch (selectOffenseString)
            {
                case "1":
                    codeString = "2";
                    break;
                case "2":
                    codeString = "9";
                    break;
                case "3":
                    codeString = "G";
                    break;
                case "4":
                    codeString = "N";
                    break;
                case "5":
                    codeString = "O";
                    break;
                case "6":
                    codeString = "V";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseThree()
        {
            switch (selectOffenseString)
            {
                case "1":
                    codeString = "1";
                    break;
                case "2":
                    codeString = "8";
                    break;
                case "3":
                    codeString = "F";
                    break;
                case "4":
                    codeString = "M";
                    break;
                case "5":
                    codeString = "T";
                    break;
                case "6":
                    codeString = "U";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseFour()
        {
            switch (selectOffenseString)
            {
                case "1":
                    codeString = "0";
                    break;
                case "2":
                    codeString = "7";
                    break;
                case "3":
                    codeString = "E";
                    break;
                case "4":
                    codeString = "L";
                    break;
                case "5":
                    codeString = "S";
                    break;
                case "6":
                    codeString = "Z";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseFive()
        {
            switch (selectOffenseString)
            {
                case "1":
                    codeString = "4";
                    break;
                case "2":
                    codeString = "B";
                    break;
                case "3":
                    codeString = "C";
                    break;
                case "4":
                    codeString = "J";
                    break;
                case "5":
                    codeString = "Q";
                    break;
                case "6":
                    codeString = "X";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseSix()
        {
            switch (selectOffenseString)
            {
                case "1":
                    codeString = "6";
                    break;
                case "2":
                    codeString = "5";
                    break;
                case "3":
                    codeString = "D";
                    break;
                case "4":
                    codeString = "K";
                    break;
                case "5":
                    codeString = "R";
                    break;
                case "6":
                    codeString = "Y";
                    break;
            }
            return codeString;
        }


        private string GetDigitThree()
        {
            int selectPlaneEnergyInt;
            string selectPlaneEnergyString;

            selectPlaneEnergyInt = int.Parse(selectPlaneEnergyLevelComboBox.Text);
            selectPlaneEnergyString = selectPlaneEnergyInt.ToString();

            selectSpecialWeaponEnergyInt = int.Parse(selectSpecialWeaponStrengthComboBox.Text);
            selectSpecialWeaponEnergyString = selectSpecialWeaponEnergyInt.ToString();


            switch (selectPlaneEnergyString)
            {
                case "1":
                    GetDigitTwoCaseSweOne();
                    codeString = GetDigitTwoCaseSweOne();
                    break;
                case "2":
                    GetDigitTwoCaseSweTwo();
                    codeString = GetDigitTwoCaseSweTwo();
                    break;
                case "3":
                    GetDigitTwoCaseSweThree();
                    codeString = GetDigitTwoCaseSweThree();
                    break;
                case "4":
                    GetDigitTwoCaseSweFour();
                    codeString = GetDigitTwoCaseSweFour();
                    break;
                case "5":
                    GetDigitTwoCaseSweFive();
                    codeString = GetDigitTwoCaseSweFive();
                    break;
                case "6":
                    GetDigitTwoCaseSweSix();
                    codeString = GetDigitTwoCaseSweSix();
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseSweOne()
        {
            switch (selectSpecialWeaponEnergyString)
            {
                case "1":
                    codeString = "I";
                    break;
                case "2":
                    codeString = "O";
                    break;
                case "3":
                    codeString = "V";
                    break;
                case "4":
                    codeString = "U";
                    break;
                case "5":
                    codeString = "W";
                    break;
                case "6":
                    codeString = "H";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseSweTwo()
        {
            switch (selectSpecialWeaponEnergyString)
            {
                case "1":
                    codeString = "D";
                    break;
                case "2":
                    codeString = "J";
                    break;
                case "3":
                    codeString = "Q";
                    break;
                case "4":
                    codeString = "P";
                    break;
                case "5":
                    codeString = "X";
                    break;
                case "6":
                    codeString = "C";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseSweThree()
        {
            switch (selectSpecialWeaponEnergyString)
            {
                case "1":
                    codeString = "8";
                    break;
                case "2":
                    codeString = "E";
                    break;
                case "3":
                    codeString = "L";
                    break;
                case "4":
                    codeString = "K";
                    break;
                case "5":
                    codeString = "R";
                    break;
                case "6":
                    codeString = "6";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseSweFour()
        {
            switch (selectSpecialWeaponEnergyString)
            {
                case "1":
                    codeString = "3";
                    break;
                case "2":
                    codeString = "9";
                    break;
                case "3":
                    codeString = "G";
                    break;
                case "4":
                    codeString = "F";
                    break;
                case "5":
                    codeString = "S";
                    break;
                case "6":
                    codeString = "7";
                    break;
            }
            return codeString;
        }

        private string GetDigitTwoCaseSweFive()
        {
            switch (selectSpecialWeaponEnergyString)
            {
                case "1":
                    codeString = "Y";
                    break;
                case "2":
                    codeString = "4";
                    break;
                case "3":
                    codeString = "B";
                    break;
                case "4":
                    codeString = "A";
                    break;
                case "5":
                    codeString = "M";
                    break;
                case "6":
                    codeString = "1";
                    break;
            }
            return codeString;
        }


        private string GetDigitTwoCaseSweSix()
        {
            switch (selectSpecialWeaponEnergyString)
            {
                case "1":
                    codeString = "T";
                    break;
                case "2":
                    codeString = "Z";
                    break;
                case "3":
                    codeString = "0";
                    break;
                case "4":
                    codeString = "5";
                    break;
                case "5":
                    codeString = "N";
                    break;
                case "6":
                    codeString = "2";
                    break;
            }
            return codeString;
        }

        private string GetDigitFour()
        {
            int selectTimeLimitInt;
            string selectTimeLimitString;

            selectTimeLimitInt = int.Parse(selectSpecialWeaponTimeLimitComboBox.Text);
            selectTimeLimitString = selectTimeLimitInt.ToString();

            switch (selectTimeLimitString)
            {
                case "1":
                    codeString = "1";
                    break;
                case "2":
                    codeString = "G";
                    break;
                case "3":
                    codeString = "0";
                    break;
                case "4":
                    codeString = "W";
                    break;
                case "5":
                    codeString = "N";
                    break;
                case "6":
                    codeString = "9";
                    break;
            }
            return codeString;
        }

        private string GetDigitFive()
        {
            int defInt, offInt, pelInt, swsInt, swtlInt, totalInt, levelSelectInt, pointsLeftInt;
            int eightInt = 8;
            int numberInt = 0;
            string totalIntString, levelSelectString;

            levelSelectInt = int.Parse(selectLevelComboBox.Text);
            levelSelectString = levelSelectInt.ToString();

            defInt = int.Parse(selectDefenseComboBox.Text);
            offInt = int.Parse(selectOffenseComboBox.Text);
            pelInt = int.Parse(selectPlaneEnergyLevelComboBox.Text);
            swsInt = int.Parse(selectSpecialWeaponStrengthComboBox.Text);
            swtlInt = int.Parse(selectSpecialWeaponTimeLimitComboBox.Text);

            totalInt = defInt + offInt + pelInt + swsInt + swtlInt;
            totalIntString = totalInt.ToString();

            switch (totalIntString)
            {
                /*case "5":
                    pointsLeftTextBox.Text = "3";
                    codeString = "INVALID";
                    break;
                case "6":
                    pointsLeftTextBox.Text = "2";
                    codeString = "INVALID";
                    break;
                case "7":
                    pointsLeftTextBox.Text = "1";
                    codeString = "INVALID";
                    break;*/
                case "8":
                    if (levelSelectInt >= 1)
                    {
                        codeString = "7";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "9":
                    if (levelSelectInt >= 3)
                    {
                        codeString = "3";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "10":
                    if (levelSelectInt >= 4)
                    {
                        codeString = "A";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "11":
                    if (levelSelectInt >= 5)
                    {
                        codeString = "N";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "12":
                    if (levelSelectInt >= 6)
                    {
                        codeString = "X";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "13":
                    if (levelSelectInt >= 7)
                    {
                        codeString = "P";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "14":
                    if (levelSelectInt >= 7)
                    {
                        codeString = "D";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "15":
                    if (levelSelectInt >= 8)
                    {
                        codeString = "8";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "16":
                    if (levelSelectInt >= 9)
                    {
                        codeString = "G";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "17":
                    if (levelSelectInt >= 10)
                    {
                        codeString = "S";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "18":
                    if (levelSelectInt >= 11)
                    {
                        codeString = "Q";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "19":
                    if (levelSelectInt >= 11)
                    {
                        codeString = "J";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "20":
                    if (levelSelectInt >= 12)
                    {
                        codeString = "E";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "21":
                    if (levelSelectInt >= 13)
                    {
                        codeString = "F";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "22":
                    if (levelSelectInt >= 14)
                    {
                        codeString = "M";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "23":
                    if (levelSelectInt >= 15)
                    {
                        codeString = "R";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "24":
                    if (levelSelectInt >= 16)
                    {
                        codeString = "K";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "25":
                    if (levelSelectInt >= 17)
                    {
                        codeString = "L";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "26":
                    if (levelSelectInt >= 17)
                    {
                        codeString = "Z";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "27":
                    if (levelSelectInt >= 18)
                    {
                        codeString = "O";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "28":
                    if (levelSelectInt >= 20)
                    {
                        codeString = "5";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                case "29":
                    if (levelSelectInt >= 22)
                    {
                        codeString = "U";
                    }
                    else
                    {
                        codeString = "INVALID";
                    }
                        break;
                default:
                    codeString = "INVALID";
                    break;

            }

            pointsLeftTextBox.Clear();
            //for level 1 & 2
            if (levelSelectString == "1" && totalInt == 5 || levelSelectString == "2" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "3";
                codeString = "INVALID";
            }
            if (levelSelectString == "1" && totalInt == 6 || levelSelectString == "2" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "2";
                codeString = "INVALID";
            }
            if (levelSelectString == "1" && totalInt == 7 || levelSelectString == "2" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "1";
                codeString = "INVALID";
            }
            if (levelSelectString == "1" && totalInt == 8 || levelSelectString == "2" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "1" && totalInt >= 9 || levelSelectString == "2" && totalInt >= 9)
            {
                pointsLeftInt = (eightInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }

            //for level 3

            if (levelSelectString == "3" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "4";
            }
            if (levelSelectString == "3" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "3";
            }
            if (levelSelectString == "3" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "2";
            }
            if (levelSelectString == "3" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "1";
            }
            if (levelSelectString == "3" && totalInt == 9)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "3" && totalInt >= 10)
            {
                numberInt = 9;
                pointsLeftInt = (numberInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }

            //for level 4
            if (levelSelectString == "4" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "5";
            }
            if (levelSelectString == "4" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "4";
            }
            if (levelSelectString == "4" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "3";
            }
            if (levelSelectString == "4" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "2";
            }
            if (levelSelectString == "4" && totalInt == 9)
            {
                pointsLeftTextBox.Text = "1";
            }
            if (levelSelectString == "4" && totalInt == 10)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "4" && totalInt >= 11)
            {
                numberInt = 10;
                pointsLeftInt = (numberInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }

            //for level 5
            if (levelSelectString == "5" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "6";
            }
            if (levelSelectString == "5" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "5";
            }
            if (levelSelectString == "5" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "4";
            }
            if (levelSelectString == "5" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "3";
            }
            if (levelSelectString == "5" && totalInt == 9)
            {
                pointsLeftTextBox.Text = "2";
            }
            if (levelSelectString == "5" && totalInt == 10)
            {
                pointsLeftTextBox.Text = "1";
            }
            if (levelSelectString == "5" && totalInt == 11)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "5" && totalInt >= 12)
            {
                numberInt = 11;
                pointsLeftInt = (numberInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }



            //for level 6
            if (levelSelectString == "6" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "7";
            }
            if (levelSelectString == "6" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "6";
            }
            if (levelSelectString == "6" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "5";
            }
            if (levelSelectString == "6" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "4";
            }
            if (levelSelectString == "6" && totalInt == 9)
            {
                pointsLeftTextBox.Text = "3";
            }
            if (levelSelectString == "6" && totalInt == 10)
            {
                pointsLeftTextBox.Text = "2";
            }
            if (levelSelectString == "6" && totalInt == 11)
            {
                pointsLeftTextBox.Text = "1";
            }
            if (levelSelectString == "6" && totalInt == 12)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "6" && totalInt >= 13)
            {
                numberInt = 12;
                pointsLeftInt = (numberInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }


            //for level 7
            if (levelSelectString == "7" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "8";
            }
            if (levelSelectString == "7" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "7";
            }
            if (levelSelectString == "7" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "6";
            }
            if (levelSelectString == "7" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "5";
            }
            if (levelSelectString == "7" && totalInt == 9)
            {
                pointsLeftTextBox.Text = "4";
            }
            if (levelSelectString == "7" && totalInt == 10)
            {
                pointsLeftTextBox.Text = "3";
            }
            if (levelSelectString == "7" && totalInt == 11)
            {
                pointsLeftTextBox.Text = "2";
            }
            if (levelSelectString == "7" && totalInt == 12)
            {
                pointsLeftTextBox.Text = "1";
            }
            if (levelSelectString == "7" && totalInt == 13)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "7" && totalInt >= 14)
            {
                numberInt = 13;
                pointsLeftInt = (numberInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }

            //for level 8
            if (levelSelectString == "8" && totalInt == 5)
            {
                pointsLeftTextBox.Text = "10";
            }
            if (levelSelectString == "8" && totalInt == 6)
            {
                pointsLeftTextBox.Text = "9";
            }
            if (levelSelectString == "8" && totalInt == 7)
            {
                pointsLeftTextBox.Text = "8";
            }
            if (levelSelectString == "8" && totalInt == 8)
            {
                pointsLeftTextBox.Text = "7";
            }
            if (levelSelectString == "8" && totalInt == 9)
            {
                pointsLeftTextBox.Text = "6";
            }
            if (levelSelectString == "8" && totalInt == 10)
            {
                pointsLeftTextBox.Text = "5";
            }
            if (levelSelectString == "8" && totalInt == 11)
            {
                pointsLeftTextBox.Text = "4";
            }
            if (levelSelectString == "8" && totalInt == 12)
            {
                pointsLeftTextBox.Text = "3";
            }
            if (levelSelectString == "8" && totalInt == 13)
            {
                pointsLeftTextBox.Text = "2";
            }
            if (levelSelectString == "8" && totalInt == 14)
            {
                pointsLeftTextBox.Text = "1";
            }
            if (levelSelectString == "8" && totalInt == 15)
            {
                pointsLeftTextBox.Text = "0";
            }
            if (levelSelectString == "8" && totalInt >= 16)
            {
                numberInt = 15;
                pointsLeftInt = (numberInt - totalInt);
                pointsLeftTextBox.Text = pointsLeftInt.ToString();
                codeString = "INVALID";
            }
            //for level 9
            if (levelSelectString == "9")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 17)
                {
                    numberInt = 16;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }

            //for level 10
            if (levelSelectString == "10")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 18)
                {
                    numberInt = 17;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 11
            if (levelSelectString == "11")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 19)
                {
                    numberInt = 18;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 12
            if (levelSelectString == "12")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 21)
                {
                    numberInt = 20;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 13
            if (levelSelectString == "13")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 22)
                {
                    numberInt = 21;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 14
            if (levelSelectString == "14")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 23)
                {
                    numberInt = 22;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 15
            if (levelSelectString == "15")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 24)
                {
                    numberInt = 23;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 16
            if (levelSelectString == "16")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "19";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 24)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 25)
                {
                    numberInt = 24;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 17
            if (levelSelectString == "17")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "20";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "19";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 24)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 25)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 26)
                {
                    numberInt = 25;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 18 or 19
            if (levelSelectString == "18" || levelSelectString == "19")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "22";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "21";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "20";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "19";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 24)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 25)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 26)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 27)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 28)
                {
                    numberInt = 27;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            

            //for level 20
            if (levelSelectString == "20" || levelSelectString == "21")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "23";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "22";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "21";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "20";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "19";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 24)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 25)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 26)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 27)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 28)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 29)
                {
                    numberInt = 28;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 21
            if (levelSelectString == "21")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "24";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "23";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "22";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "21";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "20";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "19";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 24)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 25)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 26)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 27)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 28)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 29)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 30)
                {
                    numberInt = 29;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }
            //for level 22 & 23
            if (levelSelectString == "22" || levelSelectString == "23")
            {
                if (totalInt == 5)
                {
                    pointsLeftTextBox.Text = "25";
                }
                if (totalInt == 6)
                {
                    pointsLeftTextBox.Text = "24";
                }
                if (totalInt == 7)
                {
                    pointsLeftTextBox.Text = "23";
                }
                if (totalInt == 8)
                {
                    pointsLeftTextBox.Text = "22";
                }
                if (totalInt == 9)
                {
                    pointsLeftTextBox.Text = "21";
                }
                if (totalInt == 10)
                {
                    pointsLeftTextBox.Text = "20";
                }
                if (totalInt == 11)
                {
                    pointsLeftTextBox.Text = "19";
                }
                if (totalInt == 12)
                {
                    pointsLeftTextBox.Text = "18";
                }
                if (totalInt == 13)
                {
                    pointsLeftTextBox.Text = "17";
                }
                if (totalInt == 14)
                {
                    pointsLeftTextBox.Text = "16";
                }
                if (totalInt == 15)
                {
                    pointsLeftTextBox.Text = "15";
                }
                if (totalInt == 16)
                {
                    pointsLeftTextBox.Text = "14";
                }
                if (totalInt == 17)
                {
                    pointsLeftTextBox.Text = "13";
                }
                if (totalInt == 18)
                {
                    pointsLeftTextBox.Text = "12";
                }
                if (totalInt == 19)
                {
                    pointsLeftTextBox.Text = "11";
                }
                if (totalInt == 20)
                {
                    pointsLeftTextBox.Text = "10";
                }
                if (totalInt == 21)
                {
                    pointsLeftTextBox.Text = "9";
                }
                if (totalInt == 22)
                {
                    pointsLeftTextBox.Text = "8";
                }
                if (totalInt == 23)
                {
                    pointsLeftTextBox.Text = "7";
                }
                if (totalInt == 24)
                {
                    pointsLeftTextBox.Text = "6";
                }
                if (totalInt == 25)
                {
                    pointsLeftTextBox.Text = "5";
                }
                if (totalInt == 26)
                {
                    pointsLeftTextBox.Text = "4";
                }
                if (totalInt == 27)
                {
                    pointsLeftTextBox.Text = "3";
                }
                if (totalInt == 28)
                {
                    pointsLeftTextBox.Text = "2";
                }
                if (totalInt == 29)
                {
                    pointsLeftTextBox.Text = "1";
                }
                if (totalInt == 30)
                {
                    pointsLeftTextBox.Text = "0";
                }
                if (totalInt >= 31)
                {
                    numberInt = 30;
                    pointsLeftInt = (numberInt - totalInt);
                    pointsLeftTextBox.Text = pointsLeftInt.ToString();
                    codeString = "INVALID";
                }
            }


            return codeString;

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateCodeButton_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectLevelComboBox.SelectedIndex = 0;
            selectDefenseComboBox.SelectedIndex = 0;
            selectOffenseComboBox.SelectedIndex = 0;
            selectPlaneEnergyLevelComboBox.SelectedIndex = 0;
            selectSpecialWeaponStrengthComboBox.SelectedIndex = 0;
            selectSpecialWeaponTimeLimitComboBox.SelectedIndex = 0;
            pointsLeftTextBox.Clear();
            codeTextBox.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();

            aboutbox.ShowDialog();
        }

    }


}