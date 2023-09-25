using TMPro;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class LogPickUp : MonoBehaviour
{
    [SerializeField] GameObject log;
    private int logs;
    [SerializeField] private TMP_Text logText;



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Log")
        {
            log.SetActive(false);
            logs++;
            Debug.Log("1");
            logText.text = "LOGS: " + logs;

        }
    }




}
