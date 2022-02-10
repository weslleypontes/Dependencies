using Dependencies.Entities.Enum;

namespace Dependencies.Entities
{
    internal class Worker
    {
        //Propriedades da classe trabalador
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        // Aqui vou fazer uma associaçao entre duas classes(objetos) 
        //pq a classe worker e DEpartment estao associadas!
        // para isso eu crio uma propriedade do tipo da classe que eu quero associar com Worker
        //no caso Department 
        //com isso eu estou associandos as duas classes(objetos)
        public Department Department { get; set; }
    }
}
