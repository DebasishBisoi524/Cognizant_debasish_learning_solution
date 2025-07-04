package com.example;

import org.junit.Before;
import org.junit.After;
import org.junit.Test;
import static org.junit.Assert.*;

public class BankAccountTest {

    private BankAccount account;

    // Runs before each @Test
    @Before
    public void setUp() {
        account = new BankAccount(1000); // Arrange
        System.out.println("Setup: BankAccount initialized with 1000");
    }

    // Runs after each @Test
    @After
    public void tearDown() {
        account = null;
        System.out.println("Teardown: BankAccount object cleared");
    }

    @Test
    public void testDeposit() {
        // Act
        account.deposit(500);

        // Assert
        assertEquals(1500, account.getBalance(), 0.01);
    }

    @Test
    public void testWithdrawValid() {
        // Act
        account.withdraw(300);

        // Assert
        assertEquals(700, account.getBalance(), 0.01);
    }

    @Test(expected = IllegalArgumentException.class)
    public void testWithdrawInsufficientFunds() {
        // Act
        account.withdraw(2000);

        // Assert is not needed — we expect exception
    }
}
