namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Sydney et mon jeu préféré est Kirby triple deluxe");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton prénom");
        string prenom = Console.ReadLine();
        Console.WriteLine("Quel est ton âge");
        int age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age >= 18)
        {
            Console.WriteLine("tu es majeur");
        }
        else
        {
            Console.WriteLine("tu es mineur");
        }
       
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euros as-tu ?");
        int argent = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("Arme 1: couteau-1€");
        Console.WriteLine("Arme 2: hache-5€");
        Console.WriteLine("Arme 3: katana-10€");
        Console.WriteLine("Arme 4: bombe-20€");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("quel arme choisi tu ? (1,2,3,4)");
        int choix = Convert.ToInt32(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}