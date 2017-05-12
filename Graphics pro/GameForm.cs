using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * openGl Lib
 * 
 * */
using ShadowEngine;
using Tao.OpenGl;
using ShadowEngine.OpenGL;
using ShadowEngine.ContentLoading;
using CarRace; 

namespace Graphics_pro
{
    public partial class GameForm : Form
    {
        uint hdc;
        int selectedCamara = 1;
        int count;
        GameControl control = new GameControl(); //selected car index
        int mostrado = 0;
        int moving;
        Timer redrawTimer;
        String first;
        public GameForm()
        {
            InitializeComponent();

            redrawTimer = new Timer();
            redrawTimer.Enabled = true;
            redrawTimer.Interval = 25;
            redrawTimer.Tick += new EventHandler(redraw);


            hdc = (uint)this.Handle;
            string error = "";
            OpenGLControl.OpenGLInit(ref hdc, this.Width, this.Height, ref error);
            control.Cam.SetPerspective();
            Lighting.SetupLighting();

            ContentManager.SetTextureList("textures\\");
            ContentManager.LoadTextures();
            ContentManager.SetModelList("models\\");
            ContentManager.LoadModels();

            control.CreateObjects();
            GameControl.StartedRace = true;   
        }

        private void redraw(object sender, EventArgs e)
        {
            UpdateLogic();
            // clean opengl to draw
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            //draws the entire scene
            control.DrawScene();
            //change buffers
            Winapi.SwapBuffers(hdc);
            //tell opengl to drop any operation he is doing and to prepare for a new frame
            Gl.glFlush();
        }
        public void UpdateLogic()
        {
            if (moving == 1)
            {
                Gl.glTranslatef(0, 0, 0.35f);
                //if (GameControl.newUserSpeed <= 0)
                //    Gl.glTranslatef(0, 0, 0);
            }
            else
                if (moving == -1)
                {
                    Gl.glTranslatef(0, 0, -0.35f);
                    //if(GameControl.newUserSpeed <= 0)
                    //    Gl.glTranslatef(0, 0, 0);

                }
            count++;
            if (GameControl.FinishedRace == true && mostrado == 0)
            {
                mostrado = 1;
                moving = 0;
                MessageBox.Show("The winner was the: " + first);
                control.ResetRace();
                global.gameForm = this;
                this.Hide();
                global.mainForm.Show();
            }

            if (count == 10)
            {
                if (GameControl.StartedRace == true && mostrado == 0)
                {
                    int primero = control.GetFirstPlace();
                    float distanciaRecorrida = control.GetDistanceInMeters(primero);
                    switch (primero)
                    {
                        case 0:
                            {
                                first = "Green Car";
                                break;
                            }
                        case 1:
                            {
                                first = "Fuchsia";         
                                
                                break;
                            }
                        case 2:
                            {
                                first = "Red";
                                break;
                            }
                    }
                }
                count = 0;
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Environment.Exit(0);
            if(e.KeyCode == Keys.W)
            {
                GameControl.StartedRace = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                selectedCamara++;
                if (selectedCamara == 5)
                {
                    selectedCamara = 1;
                }
                //lblCamara.Text = Convert.ToString(selectedCamara);
                control.Cam.SelectCam(selectedCamara - 1);
            }
            if(e.KeyCode == Keys.Left)
            {
                selectedCamara--;
                if (selectedCamara == 0)
                {
                    selectedCamara = 4;
                }
                //lblCamara.Text = Convert.ToString(selectedCamara);
                control.Cam.SelectCam(selectedCamara - 1);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                moving = 0;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (GameControl.newUserSpeed < 0.9)
                    GameControl.newUserSpeed += (float)0.008;
            }
            else if (e.KeyCode == Keys.S)
            {
                if (GameControl.newUserSpeed > 0.0)
                    GameControl.newUserSpeed -= (float)0.008;
            }

            if (e.KeyData == Keys.Up)
            {
                moving = 1;
            }
            if (e.KeyData == Keys.Down)
            {
                moving = -1;
            }
        }

    }
}
