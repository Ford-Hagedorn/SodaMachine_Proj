﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {

        //Member Variables (Has A)
        public List<Coin> Coins;
        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()
        {
            Coins = new List<Coin>();
            Coin quarter = new Quarter();
            Coin dime = new Dime();
            Coin nickel = new Nickel();
            Coin penny = new Penny();

            Coins.Add(quarter);
            Coins.Add(dime);
            Coins.Add(nickel);
            Coins.Add(penny);

            for (int i = 0; i < 12; i++)
            {
                Coins.Add(quarter);
            }
            for (int i = 0; i < 16; i++)
            {
                Coins.Add(dime);
            }
            for (int i = 0; i < 6; i++)
            {
                Coins.Add(nickel);
            }
            for (int i = 0; i < 10; i++)
            {
                Coins.Add(penny);
            }
        }
    }
}
