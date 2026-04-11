using exame;
class Program
{
    static void Main(string[] args)
    {
        Glicemia glicemia = new Glicemia();
        glicemia.cadastrarExame();
        glicemia.mostrarResultado();

        Triglicerideos triglicerideos = new Triglicerideos();
        triglicerideos.cadastrarExame();
        triglicerideos.mostrarResultado();

        Colesterol colesterol = new Colesterol();
        colesterol.cadastrarExame();
        colesterol.mostrarResultado();
    }
}