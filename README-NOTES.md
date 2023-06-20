# design-pattern 

## Note-Global 

- singleton:
- abstract class: sert de base pour autres classes qui "inherit" ces proprietes et methodes car on peut pas creer des instances de ces classes  
- comment decrire un pattern : 
1. nom
2. description
3. example de code sous forme UML
4. example d'utilisation

## Grande Famille des Patterns de construction

But : separer la creation d'objet du system 

### Pattern Abstract Factory 
- definition prof : Le but de ce pattern est de permettre de fabriquer des objets regroupes en "famille" sans avoir a connaitre les classes cibles destinee a la fabrication de ces objets 
- nom du projet : AbstractFactory
- example de UML : ![Abstract Factory](image.png)
- description: 
- architecture :

### Pattern Builder 
- definition prof : Ce pattern permet d'abstraire la construction d'objets complexes de leur implementations de sorte qu'un client puisse creer des objets complexes sans savoir a se preocupper des differences d'implementation 
- nom du projet : PatternBuilder
- example de UML : ![Pattern Builder](image.png)
- description : on utilise ce pattern pour separer les objets de leur implementations, c'est quand on veut creer des objets complexes avec plusieurs implementations 
- architecture :