using UnityEngine;
using System.Collections;

namespace Pathfinding {
	/// <summary>
	/// Sets the destination of an AI to the position of a specified object.
	/// This component should be attached to a GameObject together with a movement script such as AIPath, RichAI or AILerp.
	/// This component will then make the AI move towards the <see cref="target"/> set on this component.
	///
	/// See: <see cref="Pathfinding.IAstarAI.destination"/>
	///
	/// [Open online documentation to see images]
	/// </summary>
	[UniqueComponent(tag = "ai.destination")]
	[HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_destination_setter.php")]
	public class AIDestinationSetter : VersionedMonoBehaviour {
		/// <summary>The object that the AI should move to</summary>
		public Transform target1;
		public Transform target2;
		public bool FromAToB = false;
		private string target;
		float Distance1;
		float Distance2;
		IAstarAI ai;

		void OnEnable () {
			ai = GetComponent<IAstarAI>();
			// Update the destination right before searching for a path as well.
			// This is enough in theory, but this script will also update the destination every
			// frame as the destination is used for debugging and may be used for other things by other
			// scripts as well. So it makes sense that it is up to date every frame.
			if (ai != null) ai.onSearchPath += FixedUpdate;
		}

		void OnDisable () {
			if (ai != null) ai.onSearchPath -= FixedUpdate;
		}

		/// <summary>Updates the AI's destination every frame</summary>
		void GetDistance()
		{
			Distance1 = Vector3.Distance(target1.position, transform.position);

			Distance2 = Vector3.Distance(target2.position, transform.position);
		}

		void FixedUpdate ()
		{
			GetDistance();

			if (FromAToB)
			{
				if(target == "target1")
				{
					if(Distance1 <= 0.05f)
					{
						target = "target2";
						return;
					}

					ai.destination = target1.position;
				}
				else if (target == "target2")
				{
					if (Distance2 <= 0.05f)
					{
						target = "target1";
						return;
					}
				
					ai.destination = target2.position;
				}
				else
				{
					target = "target1";
				}

			}
			else
			{

				if (Distance1 < Distance2 && Distance1 < 10)
				{
					ai.destination = target1.position;
					//Debug.Log("Go For 1");
				}
				if (Distance1 >= Distance2 && Distance2 < 10)
				{
					ai.destination = target2.position;
					//Debug.Log("Go For 2");
				}
			}
			

		}
	}
}
