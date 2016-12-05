using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    /// <summary>
    /// An API for useful mathematical operations
    /// </summary>
    public class MathController : ApiController
    {
        /// <summary>
        /// Adds value 1 to value 2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpGet]
        public double Add(double value1, double value2)
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
        public double Subtract(double value1, double value2)
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
        public double Multiply(double value1, double value2)
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
        public double Divide(double value1, double value2)
        {
            if(value2==0)
                System.Diagnostics.Trace.TraceWarning("Attempting to divide by zero."); // will be traced in Application Insights

            return value1 / value2;
        }


        /// <summary>
        /// Raises value 1 to the power of value 2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpGet]
        public double Power(double value1, double value2)
        {
            throw new Exception("This is some sloppy code here that throws exceptions."); // will be traced in Application Insights
            return Math.Pow(value1, value2);
        }
    }
}
