# Technical Interview

## 1. Project Description

This project exposes an API that receives a prompt (query) and sends it to an LLM (Claude from Anthropic) through an endpoint. The result is returned as a JSON response. You can find it and pull it from the repository.

### Important Technologies
- **.NET 6 (ASP.NET Core)** for building the API.
- **Docker** for running and distributing the project without installing .NET locally.

## 2. Challenge

There are two challenges in this test:

### Implement a Prompt Caching System
Currently, the prompts and their responses are not stored by the system in any way. This leads to unnecessary infrastructure costs.

You can choose **two levels** of difficulty for the challenge, which affects scoring:

1. **Level 1**  
   Uses **exact matching**: it only stores the response if the query exactly matches a cached query.
2. **Level 2**  
   Implement a **semantic caching system**, so that if a semantically similar prompt arrives, the system returns the cached response instead of calling the LLM again.  
   For this, you already have code provided to use the bag-of-words method to vectorize and the cosine similarity method to calculate similarity.

### Discover the Design Error
There is a deliberate design error in the project (not specified in the document) that could cause problems in a concurrent environment.

1. **Level 1**  
   Recognize the error and propose a solution.
2. **Level 2**  
   Implement the solution.

## 3. Time Allocations

1. **10 minutes: Setup**  
   - Pull the project.  
   - Read through the tasks.

2. **60 minutes: Implementation**  
   - Implement the solution for the challenge.

3. **10 minutes: Final Tests**  
   - Verify that the solution caches the following queries.  
   - Fix errors if necessary.

## 4. Project Setup

1. **Clone or download** the repository.
2. **Prepare the `.env` file**:
   - Create a `.env` file in the root of the project containing the environment variable:
     ```
     API_KEY=<your claude API here>
     ```
3. **Build the Docker image**:
   ```bash
   docker build -t query-api .
4. **Run the Docker image**:
   ```bash
   docker run -p 8800:8800 --env-file .env query-api

