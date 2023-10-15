using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //Статическое поле, доступное любому коду
    static public bool goalMet = false;

    private void OnTriggerEnter(Collider other)
    {
        //Когда в область действия триггера попадает что то, 
        //проверить является ли это что то снарядом
        if(other.gameObject.tag=="Projectile")
        {
            //Если это снаряд, присвоить полю goalMet значение true
            Goal.goalMet = true;

            //Также изменить альфа-канал цвета, что бы увеличить непрозрачность
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
        }
    }
}
