using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;
using MyWebAPI.Repository;

namespace MyWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase, IController<Category>
{
	private DataContext _db;
	public CategoryController(DataContext db)
	{
		_db = db;
	}
	[HttpGet]
	public IActionResult Get()
	{
		List<Category> Categories = _db.Categories.ToList();
		return Ok(Categories);
	}
	[HttpGet("{id}")]
	public IActionResult Get(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		return Ok(category);
	}
	[HttpPost]
	public IActionResult Create(Category data)
	{
		_db.Categories.Add(data);
		_db.SaveChanges();
		return Ok();
	}
	[HttpPut("{id}")]
	public IActionResult Update(int id, Category data)
	{
		Category? category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		category.CategoryName = data.CategoryName;
		category.Description = data.Description;
		_db.Categories.Update(category);
		_db.SaveChanges();
		return Ok();
	}
	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return Ok();
	}
}

