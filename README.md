# SIO_Math

SIO_Math est une application Windows Forms développée en C# (.NET 8) permettant d’effectuer différentes opérations mathématiques de base et des conversions numériques.  
Elle s’adresse principalement aux étudiants ou toute personne souhaitant manipuler des outils arithmétiques simples dans une interface graphique conviviale.

## Fonctionnalités

- **Page d’accueil** : Navigation vers les différentes fonctionnalités.
- **Conversions de bases** : Conversion entre décimal, binaire et hexadécimal.
- **Arithmétique** :
  - Calcul du PGCD (Plus Grand Commun Diviseur)
  - Calcul du PPCM (Plus Petit Commun Multiple)
  - Calculs de congruence et listes de congruences

## Structure du projet

- `homePage/` : Page d’accueil (`HomePage`)
- `conversions/` : Conversion de bases (`ConversionPage`)
- `arithmetique/` : Fonctions arithmétiques
  - `pgcd/` : Calcul du PGCD (`PgcdPage`)
  - `ppcm/` : Calcul du PPCM (`PpcmPage`)
  - `congruence/` : Calculs de congruence (`CongruencePage`)
- `MathAppForm/` : Formulaire principal (`Form1`)

## Prérequis

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Windows (application WinForms)

## Installation

1. Clonez le dépôt :