namespace project1
{

    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                AWP awp = new AWP(10);
                awp.Zoom();
                awp.Shoot();
                awp.Reload();
            }
            catch (Exception ex)
            {    

               Console.WriteLine(ex.Message);
            }
            Console.WriteLine('\n');
            try
            {
                P92 p92 = new P92(60);
                p92.Zoom();
                p92.Shoot();
                p92.Reload();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            try
            {
                M4 m4 = new M4(30);
                m4.Shoot();
                m4.Reload();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
            Console.WriteLine('\n');
            try
            {
                AK47 ak47 = new AK47(32);
                ak47.Shoot();
                ak47.Reload();  
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}