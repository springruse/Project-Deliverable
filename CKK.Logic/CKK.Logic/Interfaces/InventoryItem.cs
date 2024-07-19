﻿using CKK.Logic.Exceptions;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        private int quantity;
        public Product Product { get; set; }

        public int Quantity
        {
            get { return quantity; }

            set
            {
                try
                {

                    if (value < 0)
                    {
                        throw new InventoryItemStockTooLowException();
                    }

                }
                catch (InventoryItemStockTooLowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
                
            }
        }
    }
}