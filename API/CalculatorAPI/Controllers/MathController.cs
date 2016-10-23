﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class MathController : ApiController
    {
        /// <summary>
        /// Adds value 1 to value 2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpGet]
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Subtracts value 2 from value 1
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpGet]
        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        /// <summary>
        /// Multiplies value 1 and value 2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpGet]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        /// <summary>
        /// Divides value 1 by value 2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpGet]
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
