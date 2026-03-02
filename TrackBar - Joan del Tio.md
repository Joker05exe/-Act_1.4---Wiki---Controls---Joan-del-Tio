# TrackBar - Joan del Tio

## Nom del control
`TrackBar` (Barra de desplaçament / Control lliscant)

## Categoria
Common Controls

## URL de la documentació oficial de Microsoft
[Documentació de System.Windows.Forms.TrackBar](https://learn.microsoft.com/ca-es/dotnet/api/system.windows.forms.trackbar)

## Descripció de la funció del control
El control `TrackBar` és una barra lliscant (slider) que permet a l'usuari seleccionar un valor numèric dins d'un rang predefinit, movent un indicador (polze o 'thumb') al llarg d'una barra horitzontal o vertical. És ideal per ajustar valors com el volum, la brillantor, o la velocitat on l'usuari no necessita introduir un número exacte sinó escollir una magnitud de forma visual i ràpida.

## Propietats més significatives
- **`Minimum` i `Maximum`**: Defineixen els límits inferior i superior del rang de valors que es poden seleccionar.
- **`Value`**: Obté o estableix el valor numèric actual on es troba el polze seleccionador de la barra.
- **`Orientation`**: Permet triar si la barra es mostra en format `Horizontal` (d'esquerra a dreta) o `Vertical` (de dalt a baix).
- **`TickFrequency`**: Especifica l'espai i el nombre de marques (ticks) visuals que es dibuixen al llarg de la barra per ajudar l'usuari a guiar-se.
- **`SmallChange` i `LargeChange`**: Determinen quant canvia el valor de la propietat `Value` quan es fa servir les fletxes del teclat (`SmallChange`) o quan es fa clic a l'espai buit de la barra a banda i banda de l'indicador (`LargeChange`).

## Events més significatius
- **`Scroll`**: Es desencadena contínuament mentre l'usuari arrossega el polze pel traçat, o quan fa clic a la barra canviant el valor d'aquesta. És el més utilitzat per reaccionar "en viu" o en temps real al canvi de valor.
- **`ValueChanged`**: Es dispara un cop el valor a la propietat `Value` s'ha modificat.

## Exemples d'ús
S'utilitza molt habitualment per modificar el volum d'un reproductor multimèdia. S'assigna el valor d'un `TrackBar` (per exemple, de 0 a 100) directament a la variable de volum del motor d'àudio a través de l'esdeveniment `Scroll` per tal de veure el canvi en el volum a mesura que l'usuari mou l'indicador. També s'empra en programes de disseny gràfic per a canviar el gruix del pinzell o l'opacitat d'una capa.

## Demostració en vídeo (GIF/MP4) de les capacitats del control
![Demostració del funcionament de TrackBar](./img/Puja_Volum.mp4)

## URL del code snippet a github
*(Substitueix l'enllaç de sota per l'enllaç permanent creat al teu compte de GitHub: [Guia oficial](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/creating-a-permanent-link-to-a-code-snippet))*

[Enllaç al fragment de codi complet - GitHub (Posa la teva URL)](https://github.com/EL_TEU_USUARI/EL_TEU_REPO/blob/main/FormOpcions.cs#L20-L28)

---
### Codi de referència per l'snippet (Ideal per capturar de mostra al GitHub):

```csharp
private void trackBarVolum_Scroll(object sender, EventArgs e)
{
    // 1. Obtenim el valor numèric actual segons la posició de l'arrossegador
    int volumActual = trackBarVolum.Value;

    // 2. Mostrem a l'usuari el nivell de volum actualitzant un control Label
    lblNivellVolum.Text = "Volum: " + volumActual.ToString() + "%";
    
    // 3. Apliquem aquest volum al motor reproductor associat
    motorAudio.EstablirNivellDeVolum(volumActual);
}
```
