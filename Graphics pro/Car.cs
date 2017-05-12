using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/*
 * openGl Lib
 * 
 * */
using ShadowEngine;
using Tao.OpenGl;
using ShadowEngine.OpenGL;
using ShadowEngine.ContentLoading; 
namespace Graphics_pro
{
    class Car
    {
        float tireAngle;
        static int carColor = 1;
        Color color;
        Position pos;
        float speed;
        float traveledDistance = 0;
        static Random randomizer = new Random(); // to randomize the speed value
        int counter;
        ModelContainer m;

        List<Mesh> tires = new List<Mesh>();
        Mesh body; // this is the chassis of the car

        int texture;


        public float DistanceFromStart
        {
            get { return traveledDistance; }
        }

        public Car()
        {
            if (carColor == 1)
            {
                color = Color.Green;
                pos = new Position(0, 10);
            }
            if (carColor == 2)
            {
                color = Color.Fuchsia;
                pos = new Position(1.5f, 10);
            }
            if (carColor == 3)
            {
                color = Color.Red;
                pos = new Position(3, 10);
            }
            carColor++;
        }

        public void ResetRace()
        {
            traveledDistance = 0;
        }

        public void createCar()
        {
            m = ContentManager.GetModelByName("carro.3DS");
            m.CreateDisplayList(); //optimice the model and load it in opengl display lists

            m.ScaleX = 0.1f;
            m.ScaleY = 0.1f;
            m.ScaleZ = 0.1f;

            foreach (var item in m.GetMeshes)
            {
                item.CalcCenterPoint();// calculate th epivot point
                switch (item.Name)
                {
                    case "tireA":
                    case "tireB":
                    case "tireC":
                    case "tire":
                    case "rimA":
                    case "rimB":
                    case "rimC":
                    case "rim":
                        tires.Add(item);
                        break;
                    case "body":
                        body = item;
                        break;
                }
            }

            if (color == Color.Green)
            {
                texture = ContentManager.GetTextureByName("bodyG.jpg");
            }
            if (color == Color.Fuchsia)
            {
                texture = ContentManager.GetTextureByName("bodyF.jpg");
            }
            if (color == Color.Red)
            {
                texture = ContentManager.GetTextureByName("bodyR.jpg");
            }
        }

        public void DrawCar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(pos.x, 0, pos.y);

            #region race logic

            if (GameControl.StartedRace == true)
            {
                //move the object the traveled distance
                Gl.glTranslatef(0, 0, traveledDistance);
                if (traveledDistance > -120)
                {
                    tireAngle -= 24;
                    traveledDistance -= speed;
                }
                else
                    if (GameControl.FinishedRace == false)
                    {
                        GameControl.FinishedRace = true;
                    }
                counter++;
                // if counter == 30 i change the speed
                if (counter == 30)
                {
                    counter = 0;
                    speed = 0.2f + (float)randomizer.NextDouble() / 20f;
                }
            }

            #endregion

            m.DrawWithTextures(); // draw the car accesories

            #region draw chasis

            Gl.glPushMatrix();
            Gl.glScalef(0.1f, 0.1f, 0.1f);

            Gl.glEnable(Gl.GL_TEXTURE_2D);// enable textures
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture);
            body.Draw();

            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            #endregion

            #region draw rolling tires

            foreach (var item in tires)
            {
                Gl.glColor3f(0.5f, 0.5f, 0.5f);//especifico el color de la rueda
                Gl.glPushMatrix();
                Gl.glScalef(0.1f, 0.1f, 0.1f);
                Gl.glTranslatef(item.CenterPoint.X, item.CenterPoint.Y, item.CenterPoint.Z); //traslada a la posicion original 
                Gl.glRotatef(tireAngle, 1, 0, 0);// se rota 
                Gl.glTranslatef(-item.CenterPoint.X, -item.CenterPoint.Y, -item.CenterPoint.Z); // traslado al centro
                item.Draw();  // dibujo la rueda 
                Gl.glPopMatrix();
                Gl.glColor3f(1, 1, 1);
            }

            #endregion

            Gl.glPopMatrix();
        }

        public void DrawCar(float newSpeed)
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(pos.x, 0, pos.y);

            #region race logic

            if (GameControl.StartedRace == true)
            {
                //move the object the traveled distance
                Gl.glTranslatef(0, 0, traveledDistance);
                if (traveledDistance > -240)
                {
                    tireAngle -= 24;
                    traveledDistance -= speed;
                }
                else
                    if (GameControl.FinishedRace == false)
                    {
                        GameControl.FinishedRace = true;
                    }
                counter++;
                // if counter == 30 i change the speed
                if (counter == 30)
                {
                    counter = 0;
                    //newSpeed 0.XXXXXX
                    speed = 0.2f + GameControl.newUserSpeed / 20f;
                    if (GameControl.newUserSpeed == 0)
                        speed = 0;
                }
            }

            #endregion

            m.DrawWithTextures(); // draw the car accesories

            #region draw chasis

            Gl.glPushMatrix();
            Gl.glScalef(0.1f, 0.1f, 0.1f);

            Gl.glEnable(Gl.GL_TEXTURE_2D);// enable textures
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture);
            body.Draw();

            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            #endregion

            #region draw rolling tires

            foreach (var item in tires)
            {
                Gl.glColor3f(0.5f, 0.5f, 0.5f);//especifico el color de la rueda
                Gl.glPushMatrix();
                Gl.glScalef(0.1f, 0.1f, 0.1f);
                Gl.glTranslatef(item.CenterPoint.X, item.CenterPoint.Y, item.CenterPoint.Z); //traslada a la posicion original 
                Gl.glRotatef(tireAngle, 1, 0, 0);// se rota 
                Gl.glTranslatef(-item.CenterPoint.X, -item.CenterPoint.Y, -item.CenterPoint.Z); // traslado al centro
                item.Draw();  // dibujo la rueda 
                Gl.glPopMatrix();
                Gl.glColor3f(1, 1, 1);
            }

            #endregion

            Gl.glPopMatrix();
        }
    }
}
