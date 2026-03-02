# ColorDialog - Joan del Tio

## Nom del control
`ColorDialog` (Quadre de diàleg de colors)

## URL de la documentació oficial de Microsoft
[Documentació de System.Windows.Forms.ColorDialog](https://learn.microsoft.com/ca-es/dotnet/api/system.windows.forms.colordialog)

## Descripció de la funció del control
El control `ColorDialog` és un quadre de diàleg estàndard (Common Dialog) de Windows Forms que proporciona una interfície predefinida perquè l'usuari final pugui seleccionar un color d'una paleta o definir els seus propis colors personalitzats (introduint valors RGB o HSL). Evita al programador haver de dissenyar una finestra d'elecció de color des de zero. S'utilitza habitualment per permetre a l'usuari canviar l'aparença d'una aplicació (ex. color de fons, color de lletra o seleccions de pinzells per a dibuixar).

## Propietats més significatives
- **`Color`**: És la propietat més important. Obté o estableix el color actualment seleccionat al quadre de diàleg. Al final, és el color que recuperes quan el diàleg es tanca.
- **`AllowFullOpen`**: Obté o estableix un valor booleà que indica si l'usuari pot obrir la secció avançada del diàleg (botó "Define Custom Colors" / "Definir colores personalizados").
- **`AnyColor`**: Indica si el diàleg de color ha de mostrar tots els colors bàsics disponibles.
- **`CustomColors`**: Permet obtenir o establir una matriu de nombres enters (fins a un màxim de 16) que representen els colors personalitzats desats al quadre de diàleg.
- **`SolidColorOnly`**: Determina si es restringeix a l'usuari a seleccionar únicament colors sòlids.
- **`ShowHelp`**: Indica si s'ha de mostrar un botó d'Ajuda ("Help") al quadre de diàleg.

## Events més significatius
Com a quadre de diàleg genèric que interromp el flux normal de l'aplicació fins que es tanca (`ShowDialog()`), la seva funcionalitat es basa més en el valor de retorn (el `DialogResult`) que no pas en la programació associada a esdeveniments, no obstant l'event heretat més rellevant és:
- **`HelpRequest`**: Es desencadena quan l'usuari fa clic al botó d'Ajuda del quadre de diàleg (es requereix que la propietat `ShowHelp` estigui a `true`). Se sol emprar per obrir una pestanya o finestra amb explicacions sobre com triar el color.

## Exemples d'ús
El cas d'ús típic consisteix a associar el mètode `.ShowDialog()` a l'esdeveniment `Click` d'un control (ex: un botó). Quan l'usuari fa clic, la finestra del diàleg apareix en pantalla. Després de comprovar que l'usuari ha acceptat l'elecció amb un botó de tipus `OK` / "D'acord", s'assigna l'informació continguda a la propietat `Color` al control desitjat, com un Form o un Label (per exemple, per a actualitzar-ne l'atribut `BackColor` o `ForeColor`).

## Demostració en vídeo (GIF/MP4) de les capacitats del control
![Demostració del funcionament de ColorDialog](./img/Cambiar_color.mp4)

## URL del code snippet a github
[Enllaç al fragment de codi complet - GitHub](https://github.com/Joker05exe/-Act_1.4---Wiki---Controls---Joan-del-Tio/blob/colordialog-joan/ExemplesControls/Form1.cs#L14-L28)

---
### Codi de referència per l'snippet (Pots usar el següent text per apujar-lo a GitHub):

```csharp
private void btnCanviarColorFons_Click(object sender, EventArgs e)
{
    // 1. Instanciem el quadre de diàleg
    ColorDialog dlgCanviarColor = new ColorDialog();

    // 2. Configurem les opcions principals:
    dlgCanviarColor.AllowFullOpen = true; // Permetre colors personalitzats
    dlgCanviarColor.ShowHelp = true;      // Mostrar botó d'ajuda
    dlgCanviarColor.Color = this.BackColor; // Color per defecte en obrir

    // 3. Mostrem form i intercepte si l'usuari ha premut OK
    if (dlgCanviarColor.ShowDialog() == DialogResult.OK)
    {
        // 4. Apliquem el color seleccionat per l'usuari al fons del formulari principal
        this.BackColor = dlgCanviarColor.Color;
    }
}
```
