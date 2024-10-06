namespace _28_EventYangin
{

    internal class Kablo
    {
        public event EventDelegate Yandim;

        public void AkimGecir()
        {
            Console.WriteLine("Kablo Yandi");
            Yandim(this);
        }
    }
}