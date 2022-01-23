DEFINITION:

This means that every class, or similar structure, in your code should have only one job to do. 
Everything in that class should be related to a single purpose. Our class should not be like a 
Swiss knife wherein if one of them needs to be changed then the entire tool needs to be altered. 
It does not mean that your classes should only contain one method or property. There may be many 
members as long as they relate to single responsibility.

WHAT I GOT FROM IT:

A program can be divided into separate domains (classes, services, viewmodels, etc) and sub-domains
(classes - Student, Teacher, Lesson). Within these domains and sub-domains, functions should ideally
only be performed on a domain element within it's own context.

Example:

Student class has only properties assigned to a student.
Student class has methods that only apply to a student and interact MAINLY with the student, like a method
called Student.Study(). A Student class wouldn't have a method like Student.PrepareLesson(teacher) which uses
the passed in Teacher to create a lesson. The PrepareLesson method would be in the Teacher class