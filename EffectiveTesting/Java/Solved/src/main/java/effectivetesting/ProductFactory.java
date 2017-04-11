package effectivetesting;

public class ProductFactory {
	private final IdGenerator idGenerator;

	public ProductFactory(IdGenerator idGenerator) {
		this.idGenerator = idGenerator;
	}

	public Product create(String name) {
		final int id = idGenerator.nextId();
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
