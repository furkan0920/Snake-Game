using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw5_snake_dll;

namespace ce103_hw5_snake_test
{
    [TestClass]
    public class UnitTest1
    {

        /* [TestMethod]
         public void collisionSnake_test_1()
         {
             Class1 eat = new Class1();
             int 
         }*/



        [TestMethod]
        public void collisionDetection_test_1()
        {
            Class1 eat = new Class1();
            int consoleWidth = 50;
            int consoleHeight = 50;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 10;
            snakeXY[1, 0] = 20;
            int snakeLength = 10;
            bool situation = eat.collisionDetection(snakeXY, consoleWidth, consoleHeight, snakeLength);
            Assert.AreEqual(false, situation);
        }

        [TestMethod]
        public void collisionDetection_test_2()
        {
            Class1 eat = new Class1();
            int consoleWidth = 60;
            int consoleHeight = 60;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 40;
            int snakeLength = 20;
            bool situation = eat.collisionDetection(snakeXY, consoleWidth, consoleHeight, snakeLength);
            Assert.AreEqual(false, situation);
        }

        [TestMethod]
        public void collisionDetection_test_3()
        {
            Class1 eat = new Class1();
            int consoleWidth = 70;
            int consoleHeight = 70;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 30;
            snakeXY[1, 0] = 60;
            int snakeLength = 30;
            bool situation = eat.collisionDetection(snakeXY, consoleWidth, consoleHeight, snakeLength);
            Assert.AreEqual(false, situation);
        }
        [TestMethod]
        public void Eatfood_test_1()
        {
            Class1 eat = new Class1();
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 10;
            int[] foodXY = { 5, 5 };
            Assert.AreEqual(false, eat.eatFood(snakeXY, foodXY));
        }
        [TestMethod]
        public void Eatfood_test_2()
        {
            Class1 eat = new Class1();
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 10;
            int[] foodXY = { 6, 6 };
            Assert.AreEqual(false, eat.eatFood(snakeXY, foodXY));
        }
        [TestMethod]
        public void Eatfood_test_3()
        {
            Class1 eat = new Class1();
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 10;
            int[] foodXY = { 7, 7 };
            Assert.AreEqual(false, eat.eatFood(snakeXY, foodXY));
        }
        [TestMethod]
        public void collisionSnake_test_1()
        {
            Class1 eat = new Class1();
            int x = 80;
            int y = 80;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 70;
            snakeXY[1, 0] = 80;
            int snakeLength = 70;
            bool situation = eat.collisionDetection(snakeXY, x, y, snakeLength);
            Assert.AreEqual(false, situation);
        }
        [TestMethod]
        public void collisionSnake_test_2()
        {
            Class1 eat = new Class1();
            int x = 30;
            int y = 30;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 10;
            snakeXY[1, 0] = 20;
            int snakeLength = 10;
            bool situation = eat.collisionDetection(snakeXY, x, y, snakeLength);
            Assert.AreEqual(false, situation);
        }
        [TestMethod]
        public void collisionSnake_test_3()
        {
            Class1 eat = new Class1();
            int x = 60;
            int y = 60;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 50;
            snakeXY[1, 0] = 60;
            int snakeLength = 50;
            bool situation = eat.collisionDetection(snakeXY, x, y, snakeLength);
            Assert.AreEqual(false, situation);
        }
    }
}