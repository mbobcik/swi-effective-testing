package effectivetesting;

import java.util.Random;

public class IdGenerator {
	private static final Random random = new Random();

	public static int nextId() {
		return random.nextInt(100);
	}
}
