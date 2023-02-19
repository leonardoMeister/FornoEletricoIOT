namespace FornoEletricoIOT
{
    public class Mib
    {
        public bool SendRequestIOT(Oven oven)
        {
            if(oven == null)
            {
                return false;
            }

            return true;
        }
    }
}