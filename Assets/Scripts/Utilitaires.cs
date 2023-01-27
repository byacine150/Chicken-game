using UnityEngine;

/// <summary>
/// Classe qui contient une méhode utilitaires pour Unity
/// 
/// Auteur: Enseignants de 420-C1B-BB
/// </summary>
public class Utilitaires
{
    /// <summary>
    /// Cette méthode permet de déterminer si un objet en voit un autre.
    /// Si l'objet est visible à l'intérieur d'une distance maximale et dans un champ de vision
    /// représenté par un angle, elle retourne vrai.
    /// 
    /// Si vous avez deux GameObject, poulet et renard. Vous pouvez l'appeler de la façon suivante:
    /// 
    /// bool pouletVisible = Utilitaires.ProieVisible(renard, poulet, 10.0f, 40.0f, new Vector3(0, 1, 0));
    /// 
    /// </summary>
    /// <param name="chasseur">L'objet qui regarde</param>
    /// <param name="proie">L'objet qu'on veut voir</param>
    /// <param name="distanceMax">La distance maximale entre le chasseur et la proie pour qu'elle soit visible</param>
    /// <param name="angleMax">La moitié du champ de vision du chasseur.</param>
    /// <param name="hauteurYeux">La hauteur des yeux du chasseur. Pour éviter de voir le sol au lieu de la proie</param>
    /// <returns>Vrai si le chasseur voit la proie</returns>
    public static bool ProieVisible(GameObject chasseur, GameObject proie, float distanceMax, float angleMax, Vector3 hauteurYeux)
    {
        bool visible = false;
        RaycastHit hit;

        Vector3 positionProie = proie.transform.position;
        Vector3 positionYeuxChasseur = chasseur.transform.position + hauteurYeux;

        Vector3 directionProie = positionProie - positionYeuxChasseur;

        if (Physics.Raycast(positionYeuxChasseur, directionProie, out hit, distanceMax))
        {
            // Debug.DrawLine(positionRenardElevee, hit.point);
            // Debug.Log(hit.transform.gameObject.name);
            if (hit.transform == proie.transform)
            {
                // Il n'y a pas d'obstacle, on vérifie l'angle
                float angle = Vector3.Angle(chasseur.transform.forward, directionProie);
                //Debug.Log(angle);
                visible = angle <= angleMax;
            }
        }
        return visible;
    }
}
