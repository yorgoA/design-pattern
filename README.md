# design-pattern 

## Note-Global 

- singleton: le concept d'instancier une classe  
- abstract class: sert de base pour autres classes qui "inherit" ces proprietes et methodes car on peut pas creer des instances de ces classes  
- comment decrire un pattern : 
1. nom
2. description
3. example de code sous forme UML
4. example d'utilisation

## Premiere Grande Famille: Patterns de construction

But : separer la creation d'objet du system 

### Pattern Abstract Factory 
- definition  : Le but de ce pattern est de permettre de fabriquer des objets regroupes en "famille" sans avoir a connaitre les classes cibles destinee a la fabrication de ces objets 
- nom du projet : AbstractFactory
- example de UML : ![Abstract Factory](/imgs/Abstract.png)
- relation du UML avec le pattern : une structure de classes qui pour creer des familles d'objets liés sans connaitre les classes concrètes specifiques
- description:le pattern Abstract Factory fournit une abstraction pour créer des familles d'objets lies 
- Utilisation : when we need to create many objects that are related , but you want to keep the creation flexible so we use abstract classes instead of specific classes 

### Pattern Builder 
- definition  : Ce pattern permet d'abstraire la construction d'objets complexes de leur implementations de sorte qu'un client puisse creer des objets complexes sans savoir a se preocupper des differences d'implementation 
- nom du projet : PatternBuilder
- example de UML : ![Pattern Builder](/imgs/Builder.png)
- relation du UML avec le pattern : when we need to create complex objects and we want to separate the construction of the object from its final use while providing them with one interface 
- utilisation: when we have complex objects with many attributs , its simplify the construction of these objects or its modifications without touching or breaking the main code  

### Pattern Factory Method

definition  : Introduire une methode abstraite de creation d'objet en reprtant la aux sous-classes concretes de creation effective 
- nom du projet : FactoryBuilder
- example de UML : ![Factory Builder](/imgs/Factory.png)
- relation du UML avec le pattern : 
- description : Une methode basic pour les parents de transmettre leur attribut a leur enfants 

### Pattern Singleton
- definition  : Il faut s'assurer de deux choses lorsqu'on veut mettre en place ce pattern : 
1. une classe ne doit posseder qu'une seule instance 
2. il faut fournir une methode de classe qui permet de fournir cette instance unique 
- nom du projet : Sigleton
- utilisation : quand on a besoin qune classe a une seul instance dans tout le code , ca peut etre bien pour exaple des liens avec des base de donnees 

### Pattern Prototype 
definition: le but dde ce pattern est de creer de nouveau objets en dupliquant ddes objets existants appeler "prototypes" .
- nom du projet : Prototype
- example de UML : ![Prototype Builder](/imgs/Prototype.png)
- relation du UML avec le pattern : les iterfaces prototypes definit la methode clone , Ensuite les classe concretes permet d'implementer ce clonage 
- description : ca permet de reduire les couts et augmenter la performances , car au lieu de creer a chaque fois on le clone 

## Deuxieme Famille : Pattern de structuration

Definition prof : L’objectif des patterns de structuration est de faciliter l’indépendance de l’interface d’un objet ou d’un ensemble d’objets vis-à-vis de son implantation. 

## Pattern Adapter 
- definition: le but ici est d'adapter l'interface d'une classe donne afin qu'elle puissent interagir avec un client 
- nom du projet : Adapter
- example de UML : ![Adapter Builder](/imgs/Adapter.png)
- relation du UML avec le pattern : 
- description : son but est de faire collaborer des classes qui sont normalement incompatibles , alors on a des classe pour adapter des interfaces pour qu il puiosse interagire avec le client 
- utilisation : si on recupere une api externe et on veut "jouer" avec ces donner on utilise le pattern d'adapter pour pouvoir modifier l'interface et la rendre compatible avec les besoins du clients 

## Pattern Decorator 
- definition : ajouter en dynamique des objets sans forcement touches au code source , et sans interagire avec l'interface , c'est une alternative a la creation d'une sous classe pour ajouter des fonctionalites a un objet
- nom du projet : Decorator
- example de UML : ![Decorator Builder](/imgs/Decorator.png)
- description :on peut ajouter des comportements differents a des objets existant sans les modifier grace a des decorateurs 
- utilisation :si on veut mettre plusieurs composant graphiques , permettant a chaque utilisateur de customizer grace a ces decorateurs .

## Pattern Bridge 
- definition : Separe abstraction de l'implementation , il peuvent varier independament de l'autre 
- nom du projet : Bridge
- example de UML : ![Bridge Builder](/imgs/bridge1.png)
- example de UML : ![Bridge Builder](/imgs/bridge2.png)
- description :on trouve des classes abstraites (abstraction) qui definit les interfaces des objets clients , puis on trouve des classes refinedAbstraction qui etende ces classes d'abstraction pour ajouter des modifs
- utilisation :si on veux connecter des base differentes sans avoir a ce soucier de se confondre entre les implementations et les interfaces

## Pattern Composite 
- definition prof : Au sein de notre système de vente de véhicules, nous voulons représenter les sociétés clientes,
notamment pour connaître le nombre de véhicules dont elles disposent et leur proposer des offres de
maintenance de leur parc.
Les sociétés qui possèdent des filiales demandent des offres de maintenance qui prennent en compte le
parc de véhicules de leurs filiales.
Une solution immédiate consiste à traiter différemment les sociétés sans filiale et celles possédant des
filiales. Cependant cette différence de traitement entre les deux types de société rend l’application plus
complexe et dépendante de la composition interne des sociétés clientes.
Le pattern résout ce problème en unifiant l’interface des deux types de sociétés et en
utilisant la composition récursive. Cette composition récursive est nécessaire car une société peut
posséder des filiales qui possèdent elles-mêmes d’autres filiales.

- definition : on peut le decrire comme un arbre ou existe des noeuds de deux branches , et si on modifie un noeuds on varie ces branches , alors on peut trouver une interface qui varie des groupes d'objets de meme facon 
- nom du projet : Composite
- example de UML : ![Composite Builder](/imgs/Composite.png)
- description :On trouve des components pour les noeuds et des components pour les "branches" 
- utilisation :very good for one too many relations 

## Troisieme Famille de pattern : Pattern de comportement

Definition du livre Fiodar_Sazanavets : Behavioral design patterns tell us how objects are supposed to behave.

### Chain of responsibility 

- definition : comme le nom indique c'est une chain (une suite) de traitements qui a chaque traitements a des comportements differents la permettant de faire passer le process ou non
- nom du projet : Chain of responsibility
- example de UML : ![Chain of responsibility Builder](/imgs/Chain.png)
- description :on trouve une classe Handler qui represente l'interface commune pour tout les objets de la chaine , alors on delegue la responsabilite du traitements de donnees a ces objets qui sont differents et a chacune de choisire si ca doit passer ou non 
- utilisation : si on veux ajouter bcp de filtre a nos requete 

### Iterator pattern 

- definition :Le pattern Iterator permet de fournir un moyen d'accéder séquentiellement aux éléments d'une collection sans exposer sa structure interne. Il encapsule l'accès et la navigation dans une collection, permettant aux clients de traiter chaque élément de manière uniforme, sans avoir à se soucier de la manière dont la collection est implémentée 
- nom du projet : Iterator
- example de UML : ![Iterator Builder](/imgs/Iterator.png)
- description : On trouve une classe Iterator qui définit l'interface pour l'itération sur les éléments de la collection
