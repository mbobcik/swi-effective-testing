package effectivetesting;

public class ProductFactory {
	public Product create(String name) {
		final int id = IdGenerator.nextId();
		final String category = resolveCategory(id);
		return new Product(id, name, category);
	}

	private String resolveCategory(int id) {
		if (id % 10 == 0) {
			return "A";
		} else {
			return "B";
		}
	}
}
