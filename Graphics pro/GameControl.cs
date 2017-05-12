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

    public struct Position
    {
        public float x;
        public float y;
        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class GameControl
    {
        Car[] cars = new Car[3];
        GameWorld world = new GameWorld();
        CamView cam = new CamView();
        GameRoad road = new GameRoad();
        static bool startedRace;
        static int winner = -1;

        public static int selectedCarIndex;
        public static float newUserSpeed;

        public static int Winner
        {
            get { return GameControl.winner; }
            set { GameControl.winner = value; }
        }

        static bool finishedRace;

        public static bool FinishedRace
        {
            get { return GameControl.finishedRace; }
            set { GameControl.finishedRace = value; }
        }

        public static bool StartedRace
        {
            get { return GameControl.startedRace; }
            set { GameControl.startedRace = value; }
        }

        public GameControl()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
            }
        }

        public CamView Cam
        {
            get { return cam; }
        }

        public int GetFirstPlace()
        {
            float menor = cars[0].DistanceFromStart;
            int lugar = 0;
            for (int i = 1; i < cars.Length; i++)
            {
                if (menor > cars[i].DistanceFromStart)
                {
                    lugar = i;
                    menor = cars[i].DistanceFromStart;
                }
            }
            return lugar;
        }

        public int GetSecondPlace()
        {
            int primero = GetFirstPlace();

            switch (primero)
            {
                case 0:
                    {
                        if (cars[1].DistanceFromStart > cars[2].DistanceFromStart)
                        {
                            return 1;
                        }
                        else
                            return 2;
                    }
                case 1:
                    {
                        if (cars[0].DistanceFromStart > cars[2].DistanceFromStart)
                        {
                            return 0;
                        }
                        else
                            return 2;
                    }
                case 2:
                    {
                        if (cars[0].DistanceFromStart > cars[1].DistanceFromStart)
                        {
                            return 0;
                        }
                        else
                            return 1;
                    }
                default:
                    break;
            }
            return -1;
        }

        public int GetThirdPlace()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (i != GetFirstPlace() || i != GetSecondPlace())
                {
                    return i;
                }
            }
            return -1;
        }

        public float GetDistanceInMeters(int carro)
        {
            return cars[carro].DistanceFromStart * -10;
        }

        public void ResetRace()
        {
            startedRace = false;
            finishedRace = false;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ResetRace();
            }
        }

        public void CreateObjects()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].createCar();
            }
            road.Create();
        }

        public void DrawScene()
        {
            //draw the world (sky  & terrain)
            world.DrawWorld();
            //draw the road
            road.Draw();

            //draw cars

            for (int i = 0; i < cars.Length; i++)
            {
                if (selectedCarIndex != i) //exclude selected car
                    cars[i].DrawCar();
                else
                    cars[i].DrawCar(newUserSpeed);
            }
        }
    }
}
