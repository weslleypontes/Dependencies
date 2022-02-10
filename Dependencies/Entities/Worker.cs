using Dependencies.Entities.Enum;
using System.Collections.Generic;

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
        //com isso eu estou associandos as duas classes(objetos) Dependencies
        public Department Department { get; set; }

        //quando eu tiver uma associação entre duas classes do tipo 1-N 
        // nesse caso eu vou ter que fazer uma lista 
        // para representar os varios eu utilizo uma List
        // eu ja vou instanciar minha lista para ela não começar vazia
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();   

        public Worker()
        {

        }

        //vou criar ums contrutor com argumentos 
        //ATENÇÃO; eu noa vou inculir as associacoes para muitos 
        // no caso os contratos.
        // não é usual voce passar uma lista instanciado no contrutor de uma objeto 
        // regra; não colocar o objeto quando o mesmo tiver  uma associação  1-N
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        
        //criar um metodo para receber um argumento que vai adicionar na lista Contract
        public void AddContract(HourContract contract)
        {
            //minha lista Contract eu vou chamar nela o metodo Add, e adicionar o meu argumento contract
            Contracts.Add(contract);
        }

        //agora criar uma metodo para remover cantratos 
        public void RenoveContract(HourContract contract)
        {
            //operaçao para remover usando o Remove
            Contracts.Remove(contract);
        }

        //agora criar uma metodo para saber quanto o funcionaria ganhou em uma dado ano e um dado mes

        public double Income(int year, int month)
        {
            // iniciar uma varialvel soma que vai receber em primeiro lufar o salario base 
            double sum = BaseSalary;
            //para percorrer a minha lista crirar um foreach 
            // para cada HourCantract contract na minha lista de Contracts  
            foreach(HourContract contract in Contracts)
            {
                // vou criar uma if para comparar se os contratos(ano e mes) da minha lista
                // são iguais as dados que chera por parametros 
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    //agora eu vou fazer a soma receber ela msm mais o total dos contratos
                    //eu ja tenho uma operação que calcula o valor do cotrato 
                    sum += contract.TotalValue();
                }
            }
            return sum; 
        }


    }
}
