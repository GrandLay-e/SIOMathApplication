# SIO_Math

SIO_Math est une application Windows Forms d�velopp�e en C# (.NET 8) permettant d�effectuer diff�rentes op�rations math�matiques de base et des conversions num�riques.  
Elle s�adresse principalement aux �tudiants ou toute personne souhaitant manipuler des outils arithm�tiques simples dans une interface graphique conviviale.

## Fonctionnalit�s

- **Page d�accueil** : Navigation vers les diff�rentes fonctionnalit�s.
- **Conversions de bases** : Conversion entre d�cimal, binaire et hexad�cimal.
- **Arithm�tique** :
  - Calcul du PGCD (Plus Grand Commun Diviseur)
  - Calcul du PPCM (Plus Petit Commun Multiple)
  - Calculs de congruence et listes de congruences

## Structure du projet

- `homePage/` : Page d�accueil (`HomePage`)
- `conversions/` : Conversion de bases (`ConversionPage`)
- `arithmetique/` : Fonctions arithm�tiques
  - `pgcd/` : Calcul du PGCD (`PgcdPage`)
  - `ppcm/` : Calcul du PPCM (`PpcmPage`)
  - `congruence/` : Calculs de congruence (`CongruencePage`)
- `MathAppForm/` : Formulaire principal (`Form1`)

## Pr�requis

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Windows (application WinForms)

## Installation

1. Clonez le d�p�t :