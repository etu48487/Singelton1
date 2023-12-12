package Builder;

public class Main {
	public static void main(String[] args) {
		VeganRamenBuilder vegan =  new VeganRamenBuilder();
		MisoRamenBuilder miso = new MisoRamenBuilder();
		SpicyRamenBuilder spicy = new SpicyRamenBuilder();
		
		RamenChef chef = new RamenChef();
		RamenBowls ramen1 = chef.PrepareRamen(miso);
		System.out.println("canard1");
		RamenBowls ramen2 = chef.PrepareRamen(vegan);
		System.out.println("canard2");
		RamenBowls ramen3 = chef.PrepareRamen(spicy);
		System.out.println("canard3");
		
		System.out.println(ramen1.FinishedBowlOfRamen());
		System.out.println(ramen2.FinishedBowlOfRamen());
		System.out.println(ramen3.FinishedBowlOfRamen());
		
	}
}
