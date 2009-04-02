class TestSuite
	def initialize
		@tests=[]
	end
	
	def add(test)
		@tests.push(test)
	end
	def run(result)
		@tests.each do |t|
			t.run(result)
		end

	end
end
