using System;

public class CommandeCredit : Commande
{
  public CommandeCredit(double montant) : base(montant){}

  public override void paye()
  {
    Console.WriteLine(
      "Le paiement de la commande au cr�dit de : " +
      montant + " est effectu�.");
  }

  public override bool valide()
  {
    return (montant >= 1000.0) && (montant <= 5000.0);
  }
}
