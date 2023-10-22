using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Image waterAlert;
	public Image soilAlert;
	public Image solarLightAlert;

	private MediatorInterface mediator;

	public UIManager() {}

	private void Start()
	{
		this.mediator = FindObjectOfType<GameDialog>();
	}

	#region Modifiers - Change UI Based on Mediator's Messages
	public void EnableWaterNeedIcon()
	{
		waterAlert.enabled = true;
	}

	public void EnableSoilNeedIcon()
	{
		soilAlert.enabled = true;
	}

	public void EnableSolarLightNeedIcon()
	{
		solarLightAlert.enabled = true;
	}

	public void DisableWaterNeedIcon()
	{
		waterAlert.enabled = false;
	}

	public void DisableSoilNeedIcon()
	{
		soilAlert.enabled = false;
	}

	public void DisableSolarLightNeedIcon()
	{
		solarLightAlert.enabled = false;
	}

	public void DisableAllNeedIcon()
	{
		DisableWaterNeedIcon();
		DisableSoilNeedIcon();
		DisableSolarLightNeedIcon();
	}
	#endregion

	#region Notifiers - Notify to Mediator a UI interaction
	public void notifyWaterButtonPressed()
	{
		this.mediator.notify(this,"WaterBtn");
	}
	#endregion
}
