using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class GameRoad
    {
        int initList;

        public void Create()
        {
            initList = Gl.glGenLists(1);
            Gl.glNewList(initList, Gl.GL_COMPILE);

            int texturaDelimitador = ContentManager.GetTextureByName("delimitador.jpg");

            //start line
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaDelimitador);
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, 8);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.5f, 0.05f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.5f, 0.05f, 1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.5f, 0.05f, 1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.5f, 0.05f, 0);
            Gl.glEnd();
            Gl.glPopMatrix();

            //end line
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, -112);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.5f, 0.05f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.5f, 0.05f, 1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.5f, 0.05f, 1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.5f, 0.05f, 0);
            Gl.glEnd();
            Gl.glPopMatrix();


            int texturaAsfalto = ContentManager.GetTextureByName("Road.jpg");
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaAsfalto);
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, -125);

            int count = 0;
            for (int y = 0; y < 125; y++)// this for loop draws the road
            {
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.8f, 0, count);
                Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.8f, 0, count + 10);
                Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.8f, 0, count + 10);
                Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.8f, 0, count);
                Gl.glEnd();
                count += 10;
            }

            Gl.glPopMatrix();

            Gl.glEndList();
        }

        public void Draw()
        {
            Gl.glCallList(initList);
        }
    }
}
