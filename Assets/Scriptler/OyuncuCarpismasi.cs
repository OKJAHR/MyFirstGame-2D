using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuncuCarpismasi : MonoBehaviour
{
    private int toplamKarpuzSayisi;
    public Vector3 baslangicPozisyonu;

    private void Start()
    {
        toplamKarpuzSayisi = GameObject.Find("ToplanabilirObjeler").transform.childCount;
        baslangicPozisyonu = gameObject.transform.position;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("toplanabilir_obje"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.karpuzSayisi++;
            print(GameManager.instance.karpuzSayisi);
        }
        else if (collision.gameObject.CompareTag("Finish"))// bayrak bu
        {
            if (SceneManager.GetActiveScene().buildIndex+1 == SceneManager.sceneCountInBuildSettings)
            {
                UIManagers.Instance.OpenQuitPanel();

            }
            else
            {
                if (toplamKarpuzSayisi == GameManager.instance.karpuzSayisi)
                {
                    UIManagers.Instance.OpenLevelComplatedPanel();
                }
            }
        }
        else if (collision.gameObject.CompareTag("Respawn"))
        {
            gameObject.transform.position = baslangicPozisyonu;
        }



    }

}
