using BookManagement.Domain.Entities;
using BookManagement.Domain.Interfaces;
using BookManagement.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> CreateAsync(User user)
    {
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetByIdAsync(Guid userId)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(u=>u.Id == userId);
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user)
    {
       _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();
    }
}