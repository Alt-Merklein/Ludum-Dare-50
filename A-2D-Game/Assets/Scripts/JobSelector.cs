using UnityEngine;
using TMPro;
public class JobSelector : MonoBehaviour
{
    public GameObject panel;
    [Header("GUI things")]
    [Space]
    public TextMeshProUGUI description;
    public TextMeshProUGUI payment;
    public TextMeshProUGUI duration;
    public void LoadJobPanel(int index){
        JobInfo info = gameObject.transform.Find("J"+ index.ToString()).gameObject.GetComponent<JobInfo>();
        //Loading the Panel
        panel.SetActive(true); //Mudar pra uma animação dps talvez sabe
        description.text = info.jobDescription;
        payment.text = "$" + info.payment.ToString();
        duration.text = info.duration.ToString() + "h";
        
    }
}
