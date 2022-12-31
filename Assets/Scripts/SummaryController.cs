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
            UpdateText("Jesteœ Altruist¹. Nie wahasz siê zareagowæ wtedy, gdy mo¿esz pomóc innym. Przedk³adasz czyjeœ dobro ponad swoje w³asne, nawet jeœli mo¿e to nieœæ ze sob¹ powa¿ne konsekwencje. ");
        }
        else
        {
            UpdateText("Jesteœ Egoist¹. Gdy masz wybór miêdzy szczêœciem swoim lub czyimœ, twoje zawsze bêdzie na pierwszym miejscu. Trafiaj¹c na dylemat zawsze najpierw zastanawiasz siê co ka¿de z mo¿liwych rozwi¹zañ da tobie. ");
        }

        if(conformism > 0)
        {
            UpdateText("Jesteœ Konformist¹. Nie narzucasz innym swojego zdania, wolisz dostosowaæ swoje do innych. Nie wy³amujesz siê ze schematu i gdy wiêkszoœæ osi¹ga cel w konkretny sposób, bêdziesz pod¹¿aæ ich œladem. ");
        }
        else
        {
            UpdateText("Jesteœ nonkonformist¹. Wytyczasz w³asne szlaki i zchodzisz z udeptanych œcie¿ek. Nie masz problemu z kwestionowaniem decyzji wiêkszoœci. Masz swoj¹ racjê i nie³atwo wp³yn¹æ na ciebie tak, by uleg³a ona zmianie. ");
        }

        if(rationalism> 0)
        {
            UpdateText("Jesteœ racjonalist¹. Analizujesz ryzyko i nie podejmujesz go jeœli nie masz pewnoœci sukcesu. Nie czujesz potrzeby sprawdzania swoich si³ tam gdzie wszyscy polegaj¹. ");
        }
        else
        {
            UpdateText("Jesteœ empiryst¹. Nie uwierzysz w coœ dopóki samemu nie sprawdzisz. Doœwiadczenia innych mog¹ byæ pomocne, jednak to twoje jest dla ciebie najwa¿niejsze. Zapewne oparzysz siê wiele razy, lecz nie pozwolisz siê oszukaæ. ");
        }

        if(courage> 0)
        {
            UpdateText("Jesteœ odwa¿ny. Nie baczysz na strach i niebezpieczeñstwa. Jeœli chcesz coœ osi¹gn¹æ, bêdziesz przeæ naprzód tak d³ugo jak bêdzie trzeba. S³owa zw¹tpienia rzadko pojawiaj¹ siê na twoich ustach. ");
        }
        else
        {
            UpdateText("Jesteœ tchórzliwy. Jeœli mo¿esz unikn¹æ niepotrzebnych niebezpieczeñstw, to zawsze z chêci¹ to zrobisz. Trudno nak³oniæ ciê do wyjœcia ze strefy w³asnego komfortu, nawet wtedy gdy coœ mo¿e zagra¿aæ innym ludziom. Wolisz nie wychylaæ siê i nie ingerowaæ w sprawy które nie musz¹ ciebie dotyczyæ. ");
        }


        textComponent.SetText(texttodisplay);
    }

    void UpdateText(string text)
    {
        texttodisplay += text;
    }
}
