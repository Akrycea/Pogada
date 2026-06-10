using Unity.Cinemachine;
using UnityEngine;
using Yarn.Unity;

public class CameraShake : MonoBehaviour
{
    public  static CameraShake Instance { get; private set; }

    private CinemachineCamera cinemachineCamera;
    private float shakeTimer;

    private void Awake()
    {
        Instance = this;
        cinemachineCamera = GetComponent<CinemachineCamera>();
    }
    private void Update()
    {
        if(shakeTimer > 0f)
        {
            shakeTimer -= Time.deltaTime;
            if(shakeTimer < 0f)
            {
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin  = 
                    cinemachineCamera.GetComponent<CinemachineBasicMultiChannelPerlin>();

                cinemachineBasicMultiChannelPerlin.AmplitudeGain = 0f;
            }
        }
    }

    [YarnCommand("camShake")]
    public void ShakeCamera()
    {
       CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
            cinemachineCamera.GetComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.AmplitudeGain = 3f;
        shakeTimer = 2f;
    }

    [YarnCommand("longCamShakeSTART")]
    public void ContinousShakeCamera()
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
     cinemachineCamera.GetComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.AmplitudeGain = 3f;
    }

    [YarnCommand("longCamShakeEND")]
    public void ContinousShakeCameraEnd()
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
     cinemachineCamera.GetComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.AmplitudeGain = 0f;
    }
}
