using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace hatchet
{
    public partial class Form1 : Form
    {
        int page = 1;
        int chance;
        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.deathSound);
        SoundPlayer planeCrashSound = new SoundPlayer(Properties.Resources.planeCrashSound);
        SoundPlayer victorySound = new SoundPlayer(Properties.Resources.victorySound);
        SoundPlayer wolfHowl = new SoundPlayer(Properties.Resources.wolfhowl);
        SoundPlayer walking = new SoundPlayer(Properties.Resources.walking);
        SoundPlayer rooster = new SoundPlayer(Properties.Resources.rooster);
        SoundPlayer eating = new SoundPlayer(Properties.Resources.eating);
        SoundPlayer airplane = new SoundPlayer(Properties.Resources.airplane);
        SoundPlayer goodbye = new SoundPlayer(Properties.Resources.goodbye);



        public Form1()
        {
            InitializeComponent();

            

            option3Button.Visible = true;
            option3Label.Visible = true;


            storyLabel.Text = "You were flying over the Canadian wilderness and your plane has crashed. You are completely lost, Do you?";
            option1Label.Text = "Go and get supplies.";
            option2Label.Text = "Go look for a nearby town.";
            option3Label.Text = "Stay put and wait for help.";
        }

        private void option1Label_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 4;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            displayPage();


        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                Random randgen = new Random();
                chance = randgen.Next(1, 3);

                if (chance == 1)
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
                displayPage();

            }
            
            

        }
        public void displayPage()
        {
            switch (page)
            {
                case 1:
                    option3Button.Visible = true;
                    option3Label.Visible = true;

                    pictureBox1.BackgroundImage = Properties.Resources.planeCrash;
                    planeCrashSound.Play();

                    storyLabel.Text = "You were flying over the Canadian wilderness and your plane has crashed. You are completely lost, Do you?";
                    option1Label.Text = "Go and get supplies.";
                    option2Label.Text = "Go look for a nearby town.";
                    option3Label.Text = "Stay put and wait for help.";
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You sit and wait for help but none arrives, you die because of lack of shelter. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.victoryScreen;
                    victorySound.Play();
                    storyLabel.Text = "You wait for a search party to find you. And they do! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Properties.Resources.Nighttime;
                    wolfHowl.Play();
                    storyLabel.Text = "Night is fast approaching. You see a cave that could work for shelter.";
                    option1Label.Text = "Sleep in the cave";
                    option2Label.Text = "Keep walking";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 5:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You go in the cave to find it the home of a hungry bear, you get eaten. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 6:
                    pictureBox1.BackgroundImage = Properties.Resources.Nighttime;
                    walking.Play();
                    storyLabel.Text = "You continue to walk, now very sleep deprived. You see a city appear in the distance, you could be hallucinating.";
                    option1Label.Text = "Walk to the city";
                    option2Label.Text = "Sleep under a nearby tree";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 7:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You continue to walk and because of how tired you are you don't notice the giant cliff in front of you and fall in. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 8:
                    pictureBox1.BackgroundImage = Properties.Resources.morning;
                    rooster.Play();
                    storyLabel.Text = "You awake an see the city wasn't a vison. As you walk to the town you see a giant cliff. Do You?";
                    option1Label.Text = "Swing across on a vine";
                    option2Label.Text = "Cross the cliff with a fallen tree";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 9:
                    pictureBox1.BackgroundImage = Properties.Resources.victoryScreen;
                    victorySound.Play();
                    storyLabel.Text = "You swing across the vine and survive. You make it to the town a few hours later. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                   
                    break;
                case 10:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You start to cross on the tree but find out it was rotten and snaps. You die. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 11:
                    pictureBox1.BackgroundImage = Properties.Resources.trees;
                    walking.Play();
                    storyLabel.Text = "You find a bunch of broken trees on the ground near the plane. Do You?";
                    option1Label.Text = "Make a fire";
                    option2Label.Text = "Get tools from the Plane";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 12:
                    pictureBox1.BackgroundImage = Properties.Resources.morning;
                    rooster.Play();
                    storyLabel.Text = "You go get tools and survive the night in the morning you are starving and kill a bunny but with no fire can't cook it, Do You?";
                    option1Label.Text = "Make a fire";
                    option2Label.Text = "Eat the bunny raw";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 13:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You can't eat raw meat. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 14:
                    pictureBox1.BackgroundImage = Properties.Resources.fire;
                    eating.Play();
                    storyLabel.Text = "You cook the bunny and enjoy breakfast";
                    option1Label.Text = "Continue";
                    option2Label.Visible = false;
                    option2Button.Visible = false;
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    option2Button.Visible = true;
                    option2Label.Visible = true;
                    break;
                case 15:
                    pictureBox1.BackgroundImage = Properties.Resources.morning;
                    rooster.Play();
                    storyLabel.Text = "You sit by the fire for the night and are starving in the morning. Do You?";
                    option1Label.Text = "Go to the plane and get tools to kill a bunny";
                    option2Label.Text = "Eat Berries in a nearby bush";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 16:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You eat all the posionous berries and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 17:
                    pictureBox1.BackgroundImage = Properties.Resources.fire;
                    eating.Play();
                    storyLabel.Text = "You go get tools and kill a rabbit";
                    option1Label.Text = "Continue";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    option2Label.Visible = false;
                    option2Button.Visible = false;
                    break;
                case 18:
                    pictureBox1.BackgroundImage = Properties.Resources.airplaneflying;
                    airplane.Play();
                    storyLabel.Text = "You hear the sounds of a plane above you. Should You";
                    option1Label.Text = "Make a smoke signal with your fire";
                    option2Label.Text = "Walk towards the sound";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    option2Button.Visible = true;
                    option2Label.Visible = true;
                    break;
                case 19:
                    pictureBox1.BackgroundImage = Properties.Resources.fire;
                    airplane.Play();
                    storyLabel.Text = "You make a smoke signal but have no clue how long it will take for them to notice. Do You?";
                    option1Label.Text = "Go get more food and water";
                    option2Label.Text = "Sit and wait for a plane";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 20:
                    pictureBox1.BackgroundImage = Properties.Resources.victoryScreen;
                    victorySound.Play();
                    storyLabel.Text = "You wait by the fire and the plane spots you and you survive. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 21:
                    pictureBox1.BackgroundImage = Properties.Resources.pond;
                    walking.Play();
                    storyLabel.Text = "You come across a pond and realise you haven't had water in days. Do you take a drink of water?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 22:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "You die of dehydration. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 23:
                    pictureBox1.BackgroundImage = Properties.Resources.gravestone;
                    deathSound.Play();
                    storyLabel.Text = "The water gave you dysentery and you die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 24:
                    pictureBox1.BackgroundImage = Properties.Resources.victoryScreen;
                    victorySound.Play();
                    storyLabel.Text = "You took a drink and headed back to the fire. You see a plane waiting for you nearby. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 99:
                    pictureBox1.BackgroundImage = Properties.Resources.thanks;
                    goodbye.Play();
                    storyLabel.Text = "Thanks for playing!";
                    option1Label.Visible = false;
                    option1Button.Visible = false;
                    option2Label.Visible = false;
                    option2Button.Visible = false;
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    

                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();

                    break;
                default:
                    break;
                    
                    


                   
                   
                  


                 
        }
        }

        private void option1Button_Click(object sender, EventArgs e)
        {

            if (page == 1)
            {
                page = 11;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 15;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                Random randgen = new Random();
                chance = randgen.Next(1, 11);

                if (chance < 8)
                {
                    page = 24;
                }
                else
                {
                    page = 23;
                }
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            displayPage();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
