﻿using System;

namespace BreakingSingleResponsibility
{
    public class Order
    {
        private ErrorLog log = new ErrorLog();
        public void PlaceOrder()
        {
            try
            {
                // Code to add order to database would be here...
            }
            catch (Exception ex)
            {
                log.LogErrorToFile(ex);
            }
        }
    }
}