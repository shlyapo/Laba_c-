namespace instrumental
{
    internal interface IBurning
    {
        public uint Temperature { get; set; }

        public bool IsBurn(int temperature);

    }
}