package help2;

import java.util.ArrayList;
import java.util.Random;

public class Process {
	String Name;
	MyInt CurrentTime=new MyInt();
	ArrayList<Flow> flows;
	int Time;
	public Process(String Name,int Time) {
		this.Time = Time;
		this.Name =Name;
		CurrentTime.setValue(0);
		Random rnd = new Random();
		flows = new ArrayList<Flow>();
		for (int i = 0; i < rnd.nextInt(10)+1; i++) {
			flows.add(new Flow(i + " ",CurrentTime, rnd.nextInt(4)+1));
		}
	}
	public void Print() {
		System.out.println(Name+" " + flows.size());
		for (Flow flow : flows) {
			System.out.println("\t" + flow.PrintInfo());
		}
	}
	public void Start() {
		CurrentTime.setValue(0);
		System.out.println("process " + Name + " started");
		for (int i = 0; i < flows.size(); i++) {
			if(flows.get(i).Status()) {
				continue;
			}
			if(flows.get(i).MaybeWork(Time - CurrentTime.getValue())) {
				flows.get(i).DoIt();
			}
			if(flows.get(i).ErrorTime(Time)) {
				
			}
			else {
				continue;
			}
		}
	}
	public boolean ProcessDone() {
		for (Flow flow : flows) {
			if(!flow.Status()) {
				return false;
			}
		}
		return true;
	}
	public String GetName() {
		return Name;
	}
}
