﻿

namespace OOPMid.util
{
    internal class GenerateId
    {
        private static int adminId = 0;
        private static int customerId = 0;

        public static int generateAdminId() {

            adminId = adminId + 1;
            return adminId;
        
        }

        public static int generateCustomerId()
        {

            customerId = customerId + 1;
            return customerId;

        }


    }
}
