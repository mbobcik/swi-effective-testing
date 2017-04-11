package effectivetesting;

import java.util.Random;

public class RandomIdGenerator implements IdGenerator {
	private static final Random random = new Random();

	public int nextId() {
		return random.nextInt(100);
	}
}
