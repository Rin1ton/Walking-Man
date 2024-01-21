using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointDriver : MonoBehaviour
{

    [Header("Joints")]

    [SerializeField] private ConfigurableJoint TopNeck;
	[SerializeField] private ConfigurableJoint BottomNeck;
	[SerializeField] private ConfigurableJoint LeftShoulder;
	[SerializeField] private ConfigurableJoint RightShoulder;
	[SerializeField] private ConfigurableJoint LeftElbow;
	[SerializeField] private ConfigurableJoint RightElbow;
	[SerializeField] private ConfigurableJoint TopSpine;
	[SerializeField] private ConfigurableJoint BottomSpine;
	[SerializeField] private ConfigurableJoint LeftHip;
	[SerializeField] private ConfigurableJoint RightHip;
	[SerializeField] private ConfigurableJoint LeftKnee;
	[SerializeField] private ConfigurableJoint RightKnee;
	[SerializeField] private ConfigurableJoint LeftHeel;
	[SerializeField] private ConfigurableJoint RightHeel;
	[SerializeField] private ConfigurableJoint LeftToe;
	[SerializeField] private ConfigurableJoint RightToe;

	[Header("Root Bone")]

	[SerializeField] private GameObject RootBone;

    // Start is called before the first frame update
    void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
