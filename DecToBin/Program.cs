uint n = 64497661;
uint size = sizeof(uint) * 8;

uint[] bin = new uint[size];
uint i = size;

if(n != 0) {
    while(n != 0)
    {
        i = i - 1;
        bin[i] = n % 2;
        n = n / 2;
    }
}
else {
    i = i - 1;
    bin[i] = 0;
}

while(i<size) {
    Console.Write(bin[i]);
    i = i + 1;
}