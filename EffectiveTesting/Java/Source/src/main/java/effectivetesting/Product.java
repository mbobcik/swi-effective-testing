package effectivetesting;

public class Product {
	private final int id;
	private final String name;
	private final String category;

	public Product(int id, String name, String category) {
		this.id = id;
		this.name = name;
		this.category = category;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public String getCategory() {
		return category;
	}
}
