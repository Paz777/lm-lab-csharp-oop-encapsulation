# A Short Exercise to Explore Object-Oriented Programming - C# - Encapsulation

---

## Study Prompts Answers

1. 

The console application is creating 2 types of bank accounts one dodgy and the other secure. For both we see the output for the account balance and a deposit is made of 30. When a deposit is made a reward of 50 is also added. 

For the dodgy bank account we can directly add rewards without depositing which you cannot do with the secure bank account. Wee see this happening 3 times and when the balance is checked you can see it reflected on the amount. 

Also you can change the dodgy bank accounts balance directly and see this change on the balance which you can not do on the secure bank account.

2.

Some of the problems with the DodgyBankAccount class is that all the instance variables for are public and the AddReward method is public. For the properties all the values can be changed directly and the method can be called directly.

3.

How SecureBankAccount is prevented from misuse is firstly all the variables are private. From outside of the class the account no, rewards and the balance can not be changed. The AddReward method is also private and can only be called from within the class. The DisplayAccountBalanceDetails reflects a better name as the method says what it is doing.
