using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SummaryController : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public GameObject textbox, text;

    private string texttodisplay="";
    private int altruism = 0;
    private int conformism = 0;
    private int rationalism = 0;
    private int courage = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pointManager = GameObject.Find("PointManager");

        altruism = pointManager.GetComponent<PointManager>().altruism;
        conformism = pointManager.GetComponent<PointManager>().conformism;
        rationalism = pointManager.GetComponent<PointManager>().rationalism;
        courage = pointManager.GetComponent<PointManager>().courage;
        Debug.Log(altruism);
        Debug.Log(conformism);
        Debug.Log(rationalism); 
        Debug.Log(courage);

        if (altruism > 0)
        {
            UpdateText("Jeste� Altruist�. Nie wahasz si� zareagow� wtedy, gdy mo�esz pom�c innym. Przedk�adasz czyje� dobro ponad swoje w�asne, nawet je�li mo�e to nie�� ze sob� powa�ne konsekwencje. ");
        }
        else
        {
            UpdateText("Jeste� Egoist�. Gdy masz wyb�r mi�dzy szcz�ciem swoim lub czyim�, twoje zawsze b�dzie na pierwszym miejscu. Trafiaj�c na dylemat zawsze najpierw zastanawiasz si� co ka�de z mo�liwych rozwi�za� da tobie. ");
        }

        if(conformism > 0)
        {
            UpdateText("Jeste� Konformist�. Nie narzucasz innym swojego zdania, wolisz dostosowa� swoje do innych. Nie wy�amujesz si� ze schematu i gdy wi�kszo�� osi�ga cel w konkretny spos�b, b�dziesz pod��a� ich �ladem. ");
        }
        else
        {
            UpdateText("Jeste� nonkonformist�. Wytyczasz w�asne szlaki i zchodzisz z udeptanych �cie�ek. Nie masz problemu z kwestionowaniem decyzji wi�kszo�ci. Masz swoj� racj� i nie�atwo wp�yn�� na ciebie tak, by uleg�a ona zmianie. ");
        }

        if(rationalism> 0)
        {
            UpdateText("Jeste� racjonalist�. Analizujesz ryzyko i nie podejmujesz go je�li nie masz pewno�ci sukcesu. Nie czujesz potrzeby sprawdzania swoich si� tam gdzie wszyscy polegaj�. ");
        }
        else
        {
            UpdateText("Jeste� empiryst�. Nie uwierzysz w co� dop�ki samemu nie sprawdzisz. Do�wiadczenia innych mog� by� pomocne, jednak to twoje jest dla ciebie najwa�niejsze. Zapewne oparzysz si� wiele razy, lecz nie pozwolisz si� oszuka�. ");
        }

        if(courage> 0)
        {
            UpdateText("Jeste� odwa�ny. Nie baczysz na strach i niebezpiecze�stwa. Je�li chcesz co� osi�gn��, b�dziesz prze� naprz�d tak d�ugo jak b�dzie trzeba. S�owa zw�tpienia rzadko pojawiaj� si� na twoich ustach. ");
        }
        else
        {
            UpdateText("Jeste� tch�rzliwy. Je�li mo�esz unikn�� niepotrzebnych niebezpiecze�stw, to zawsze z ch�ci� to zrobisz. Trudno nak�oni� ci� do wyj�cia ze strefy w�asnego komfortu, nawet wtedy gdy co� mo�e zagra�a� innym ludziom. Wolisz nie wychyla� si� i nie ingerowa� w sprawy kt�re nie musz� ciebie dotyczy�. ");
        }


        textComponent.SetText(texttodisplay);
    }

    void UpdateText(string text)
    {
        texttodisplay += text;
    }
}
