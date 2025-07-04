package com.example;

import org.junit.Test;
import static org.junit.Assert.*;

public class AssertionsTest {

    @Test
    public void testAssertions() {
        // Check if values are equal
        assertEquals("Sum should be 5", 5, 2 + 3);

        // Check a true condition
        assertTrue("5 is greater than 3", 5 > 3);

        // Check a false condition
        assertFalse("3 is not greater than 5", 3 > 5);

        // Check for null
        Object obj = null;
        assertNull("Object should be null", obj);

        // Check not null
        Object another = new Object();
        assertNotNull("Object should not be null", another);
    }
}
