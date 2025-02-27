using UnityEngine;

public class PipeSpowner : MonoBehaviour
{
    public float maxTime = 1f;
    private float timer = 0;
    public GameObject Pipe;
    public float height;
    void Start()
    {
        GameObject newPipe = Instantiate(Pipe);
        newPipe.transform.position = transform.position+new Vector3(0,Random.Range(-height,height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate (Pipe);
            newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height, height), 0);
            Destroy(newPipe, 15f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
