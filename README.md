<h1>📋 ASP.NET Core Web API for Candidate & Skills Management</h1>

<p>This project is an ASP.NET Core Web API designed to efficiently manage candidates and their associated skills using a master-detail relationship. It provides a complete solution for CRUD operations (Create, Read, Update, Delete) on candidates, while also allowing the addition of multiple skills for each candidate. The API is simple, robust, and scalable, making it an ideal choice for managing candidate skill sets.</p>

<h2>🌟 Features</h2>

<ul>
  <li><strong>Candidate Management:</strong>
    <ul>
      <li>Add, edit, view, and delete candidate records, including details like candidate name, date of birth, phone number, and an image.</li>
    </ul>
  </li>
  <li><strong>Skills Management:</strong>
    <ul>
      <li>Each candidate can have multiple skills assigned, such as technical expertise or other proficiencies. This can be dynamically added or removed from the candidate profile.</li>
    </ul>
  </li>
  <li><strong>File Upload:</strong>
    <ul>
      <li>Supports image uploads for candidates with server-side storage, enhancing the candidate profile with visual data.</li>
    </ul>
  </li>
  <li><strong>Master-Detail Relationship:</strong>
    <ul>
      <li>Seamlessly manages candidates and their associated skills in a single workflow, using a relational database model.</li>
    </ul>
  </li>
  <li><strong>JSON Stringify for Skills:</strong>
    <ul>
      <li>Skills are passed in a stringified format to simplify the data exchange between the frontend and the API.</li>
    </ul>
  </li>
  <li><strong>Database Integration:</strong>
    <ul>
      <li>Built using Entity Framework Core, the API interacts with a SQL Server database to efficiently store and retrieve data.</li>
    </ul>
  </li>
</ul>

<h2>🛠 Technologies</h2>

<ul>
  <li><strong>ASP.NET Core Web API:</strong> The main framework for developing API endpoints and business logic.</li>
  <li><strong>Entity Framework Core:</strong> Used for managing database operations, relationships, and ensuring data integrity.</li>
  <li><strong>SQL Server:</strong> Serves as the backend for storing candidate and skill data.</li>
  <li><strong>C#:</strong> The programming language behind the business logic and API.</li>
  <li><strong>HTML/CSS/JavaScript:</strong> Can be integrated with any front-end framework for a complete full-stack solution.</li>
  <li><strong>File Upload:</strong> Utilizes server-side storage for candidate images with options for uploading and updating the profile image.</li>
</ul>

<h2>🚀 API Endpoints</h2>

<ul>
  <li><strong>GET /api/Candidates:</strong> Retrieve all candidates and their associated skills.</li>
  <li><strong>POST /api/Candidates:</strong> Insert a new candidate with associated skills.</li>
  <li><strong>POST /api/Candidates/Update:</strong> Update an existing candidate along with their skills.</li>
  <li><strong>POST /api/Candidates/Delete/{id}:</strong> Delete a candidate by ID.</li>
  <li><strong>POST /api/Skills:</strong> Retrieve a list of all skills available in the database.</li>
</ul>

<p>This API is perfect for managing candidate profiles with multiple skills in a clean, organized way. It can be integrated into larger HR systems or used as a standalone service.</p>
