# Project subject 

Project : Shoe customization store , the user can choose the shoe he wants either nike or adidas , and decide the theme that can be designed on them : manga , anime , soccer, basketball or food . 

## Consigne prof 

- Objectifs : 
 
mettre au point un scenario de creation d'application d'entreprise a faire valider 
Creer une application C# avec le framework .NET ( Web, WebApi ou console)
Decrire des problematiques metiers qui necessite l'usage de design pattern etudie en cours

- Contraintes: 
 
Illustrez vos propos avec des exemples de code issus de votre solution.
Utilisez au moins 2 patterns de construction
Utilisez au moins 2 patterns de structuration
Utilisez au moins 1 pattern de comportement

- Consignes supplementaires : 
 
rendre le travail sous forme d'un depot Git documente, accompagne d'un dossier contenant le travail effectue pendant la semaine, ainsi que la prise de note effectuee

## Pattern choisi :
- Factory Method 
- Builder Pattern
- Decorator Pattern
- Composite Pattern : on a ajoute fabrik et laces , car ce pattern est normalement utilise quand on a des objets avec des composant plus petit
- Chain of responsibility : ce projet est un peu different des autres car pour pouvoir bien appliquer ce pattern j'ai modifie le concept du projet : l'utilisateur choisi un theme puis le PASS AU nIKEhANDLER , SI LE THEME N'EST PAS DIsponible chez nike il le passe a addidas

## Conclusion
Le pattern le plus adapté, à mon avis, est le Builder Pattern. Par définition, il sert à créer des objets faciles à personnaliser et c'est le plus facile pour l'avenir d'ajouter des marques ou des thèmes sans casser le code. Grâce à sa simplicité, il nous permet de créer des objets très complexes. Par exemple, on peut ajouter la couleur des lacets, la taille et plusieurs autres variables facilement.
