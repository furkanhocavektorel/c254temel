

namespace OOPMid.util
{
    internal class GenerateId
    {
        private static int motorId = 0;
        private static int otomobilId = 0;

        public int generateMotorId() {
        
            motorId = motorId + 1;
            return motorId;
        
        }

        public int generateOtomobilId()
        {

            otomobilId = otomobilId + 1;
            return otomobilId;

        }


    }
}
