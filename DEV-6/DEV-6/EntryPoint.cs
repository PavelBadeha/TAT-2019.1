﻿using System;

namespace DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
           Company company = Company.getInstance(args[0]);
            foreach(var car in company.cars)
            {
                car.Inform();
            }
            Invoker invoker = new Invoker(company);
            invoker.Invoke();       
            }                                                                    
        }
    }

